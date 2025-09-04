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
    public partial class BegriffeScreen : Form
    {
        private string _dbUserName;
        private int lastSelectedBegriffID;

        public BegriffeScreen(string dbUserName)
        {
            InitializeComponent();

            _dbUserName = dbUserName;

            ShowBegriffe();
            LoadThemen();
            LoadGK();
        }

        private void btnRtnBegriffe2Menu_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen(_dbUserName);
            menuScreen.Show();
            this.Hide();
        }

        private void btnAddBegriffe_Click(object sender, EventArgs e)
        {
            if (txtBoxBegriffBez.Text == ""
             || richTextBoxBegriffDef.Text == ""
             || comboBoxChooseThema.Text == ""
             || comboBoxChooseGK.Text == "")
            {
                MessageBox.Show("Bitte trage alle Daten des Begriffs ein.");
                return;
            }

            string selectedThema = comboBoxChooseThema.SelectedItem.ToString();
            int themenID;

            string selectedGK = comboBoxChooseGK.SelectedItem.ToString();
            int gkID;

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                string queryGetThemenID = "SELECT ThemenID From Themen WHERE Themenbezeichnung = @Themenbezeichnung";

                using (MySqlCommand cmd = new MySqlCommand(queryGetThemenID, connection))
                {
                    cmd.Parameters.AddWithValue("@Themenbezeichnung", selectedThema);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        themenID = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Kein passendes Thema gefunden.");
                        return;
                    }
                }

                string queryGetGKID = "SELECT GKID From Grundkompetenzen WHERE GKBezeichnung = @GKBezeichnung";

                using (MySqlCommand cmd = new MySqlCommand(queryGetGKID, connection))
                {
                    cmd.Parameters.AddWithValue("@GKBezeichnung", selectedGK);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        gkID = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Keine passende Grundkompetenz gefunden.");
                        return;
                    }
                }
            }

            string begriffBez = txtBoxBegriffBez.Text;
            string begriffDef = richTextBoxBegriffDef.Text;

            string queryAddBegriff = "INSERT INTO Begriffe (Begriffbezeichnung, Begriffsdefinition, ThemenID, GKID) " +
                "VALUES (@Begriffbezeichnung, @Begriffsdefinition, @ThemenID, @GKID)";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryAddBegriff, connection))
                {
                    cmd.Parameters.AddWithValue("@Begriffbezeichnung", begriffBez);
                    cmd.Parameters.AddWithValue("@Begriffsdefinition", begriffDef);
                    cmd.Parameters.AddWithValue("@ThemenID", themenID);
                    cmd.Parameters.AddWithValue("@GKID", gkID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Begriff eingetragen.");
                ShowBegriffe();
                ClearFields();
            }
        }

        private void btnDeleteBegriffe_Click(object sender, EventArgs e)
        {
            if (lastSelectedBegriffID == 0)
            {
                MessageBox.Show("Bitte wähle zunächst einen Begriff aus.");
                return;
            }

            string queryDeleteBegriff = "DELETE FROM Begriffe WHERE BegriffID = @BegriffID";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryDeleteBegriff, connection))
                {
                    cmd.Parameters.AddWithValue("@BegriffID", lastSelectedBegriffID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Der Begriff wurde entfernt.");
            ShowBegriffe();
            ClearFields();
        }

        private void btnEditBegriffe_Click(object sender, EventArgs e)
        {
            if (lastSelectedBegriffID == 0)
            {
                MessageBox.Show("Bitte wähle zunächst einen Begriff aus.");
                return;
            }

            string selectedThema = comboBoxChooseThema.SelectedItem.ToString();
            int themenID;

            string selectedGK = comboBoxChooseGK.SelectedItem.ToString();
            int gkID;

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                string queryGetThemenID = "SELECT ThemenID From Themen WHERE Themenbezeichnung = @Themenbezeichnung";

                using (MySqlCommand cmd = new MySqlCommand(queryGetThemenID, connection))
                {
                    cmd.Parameters.AddWithValue("@Themenbezeichnung", selectedThema);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        themenID = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Kein passendes Thema gefunden.");
                        return;
                    }
                }

                string queryGetGKID = "SELECT GKID From Grundkompetenzen WHERE GKBezeichnung = @GKBezeichnung";

                using (MySqlCommand cmd = new MySqlCommand(queryGetGKID, connection))
                {
                    cmd.Parameters.AddWithValue("@GKBezeichnung", selectedGK);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        gkID = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Keine passende Grundkompetenz gefunden.");
                        return;
                    }
                }
            }

            string begriffBez = txtBoxBegriffBez.Text;
            string begriffDef = richTextBoxBegriffDef.Text;

            string queryEditBegriff = "UPDATE Begriffe SET " +
                "Begriffbezeichnung = @Begriffbezeichnung, Begriffsdefinition = @Begriffsdefinition, " +
                "ThemenID = @ThemenID, GKID = @GKID " +
                "WHERE BegriffID = @BegriffID";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryEditBegriff, connection))
                {
                    cmd.Parameters.AddWithValue("@Begriffbezeichnung", begriffBez);
                    cmd.Parameters.AddWithValue("@Begriffsdefinition", begriffDef);
                    cmd.Parameters.AddWithValue("@ThemenID", themenID);
                    cmd.Parameters.AddWithValue("@GKID", gkID);
                    cmd.Parameters.AddWithValue("@BegriffID", lastSelectedBegriffID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Änderungen an dem Begriff vorgenommen.");
            ShowBegriffe();
            ClearFields();
        }

        private void btnClearBegriffe_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewShowBegriffe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBoxBegriffBez.Text = dataGridViewShowBegriffe.SelectedRows[0].Cells[1].Value.ToString();
                richTextBoxBegriffDef.Text = dataGridViewShowBegriffe.SelectedRows[0].Cells[2].Value.ToString();
                comboBoxChooseThema.Text = dataGridViewShowBegriffe.SelectedRows[0].Cells[3].Value.ToString();
                comboBoxChooseGK.Text = dataGridViewShowBegriffe.SelectedRows[0].Cells[4].Value.ToString();
                lastSelectedBegriffID = Convert.ToInt32(dataGridViewShowBegriffe.SelectedRows[0].Cells[0].Value);
            }
        }

        private void ShowBegriffe()
        {
            string queryShowBegriffe = "SELECT b. BegriffID, b.Begriffbezeichnung, b.Begriffsdefinition, t.Themenbezeichnung, g.GKBezeichnung " +
                "FROM Begriffe b JOIN Themen t ON b.ThemenID = t.ThemenID JOIN Grundkompetenzen g ON b.GKID = g.GKID";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(queryShowBegriffe, connection);

                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);

                dataGridViewShowBegriffe.DataSource = dataSet.Tables[0];
                dataGridViewShowBegriffe.Columns[0].Visible = false;
            }
        }

        private void ClearFields()
        {
            txtBoxBegriffBez.Clear();
            richTextBoxBegriffDef.Clear();
        }

        private void LoadThemen()
        {
            string queryShowThemen = "SELECT Themenbezeichnung FROM Themen";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            using (MySqlCommand cmd = new MySqlCommand(queryShowThemen, connection))
            {
                connection.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    comboBoxChooseThema.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxChooseThema.Items.Add(reader["Themenbezeichnung"].ToString());
                    }
                }
            }
        }
        private void LoadGK()
        {
            string queryShowGK = "SELECT GKBezeichnung FROM Grundkompetenzen";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            using (MySqlCommand cmd = new MySqlCommand(queryShowGK, connection))
            {
                connection.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    comboBoxChooseGK.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxChooseGK.Items.Add(reader["GKBezeichnung"].ToString());
                    }
                }
            }
        }
    }
}
