using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LernbibliothekFiA
{
    public partial class ReadingScreen : Form
    {
        private string _dbUserName;
        private int lastSelectedBegriffID;

        public ReadingScreen(string dbUserName)
        {
            InitializeComponent();

            _dbUserName = dbUserName;

            ShowBegriffe();
        }

        private void btnRtnReading2Menu_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen(_dbUserName);
            menuScreen.Show();
            this.Hide();
        }

        private void dataGridViewShowBegriffe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBoxBegriffRO.Text = dataGridViewShowBegriffe.SelectedRows[0].Cells[1].Value.ToString();
                lastSelectedBegriffID = Convert.ToInt32(dataGridViewShowBegriffe.SelectedRows[0].Cells[0].Value);

                LoadBegriffDef();
                LoadThema();
                LoadGK();
                LoadLF();
            }
        }

        private void ShowBegriffe()
        {
            string queryShowBegriffe = "SELECT BegriffID, Begriffbezeichnung FROM Begriffe b ORDER BY Begriffbezeichnung";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(queryShowBegriffe, connection);

                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);

                dataGridViewShowBegriffe.DataSource = dataSet.Tables[0];
                dataGridViewShowBegriffe.Columns[0].Visible = false;
            }
        }

        // Holt sich die entsprechende Definition zur passenden BegriffID.
        // ExecuteReader(), weil hier mehrere Zeilen ausgelesen werden.
        private void LoadBegriffDef()
        {
            string loadDef = "SELECT Begriffsdefinition FROM Begriffe WHERE BegriffID = @BegriffID";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(loadDef, connection))
                {
                    cmd.Parameters.AddWithValue("@BegriffID", lastSelectedBegriffID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                richTextBoxBegriffDefRO.Text = reader.GetString(0);
                            }
                        }
                        else
                        {
                            richTextBoxBegriffDefRO.Text = string.Empty;
                        }
                    }
                }
            }
        }

        // Holt sich die entsprechende Themenbezeichnung zur passenden BegriffID (foreign key).
        // ExecuteScalar(), weil hier nur die erste Zeile ausgelesen werden muss.
        private void LoadThema()
        {
            string loadThema = "SELECT t.Themenbezeichnung " +
                "FROM Begriffe b " +
                "JOIN Themen t ON b.ThemenID = t.ThemenID " +
                "WHERE BegriffID = @BegriffID";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(loadThema, connection))
                {
                    cmd.Parameters.AddWithValue("@BegriffID", lastSelectedBegriffID);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        textBoxThemaRO.Text = result.ToString();
                    }
                    else
                    {
                        textBoxThemaRO.Text = string.Empty;
                    }
                }
            }  
        }

        private void LoadGK()
        {
            string loadGK = "SELECT g.GKBezeichnung " +
                    "FROM Begriffe b " +
                    "JOIN Grundkompetenzen g ON b.GKID = g.GKID " +
                    "WHERE BegriffID = @BegriffID";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(loadGK, connection))
                {
                    cmd.Parameters.AddWithValue("@BegriffID", lastSelectedBegriffID);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        textBoxGKRO.Text = result.ToString();
                    }
                    else
                    {
                        textBoxGKRO.Text = string.Empty;
                    }
                }
            }
        }

        private void LoadLF() 
        {
            string loadLF = "SELECT l.LFBezeichnung " +
                "FROM Begriffe b " +
                "JOIN Themen t ON b.ThemenID = t.ThemenID " +
                "JOIN Grundkompetenzen g ON b.GKID = g.GKID " +
                "JOIN Lernfelder l ON (t.LFID = l.LFID OR g.LFID = l.LFID)" +
                "WHERE BegriffID = @BegriffID";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(loadLF, connection))
                {
                    cmd.Parameters.AddWithValue("@BegriffID", lastSelectedBegriffID);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        textBoxLFRO.Text = result.ToString();
                    }
                    else
                    {
                        textBoxLFRO.Text = string.Empty;
                    }
                }
            }
        }
    }
}
