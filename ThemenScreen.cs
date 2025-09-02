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

namespace LernbibliothekFiA
{
    public partial class ThemenScreen : Form
    {
        private string databaseConnection = "Server=127.0.0.1;Port=3306;Database=Lernbibliothek_FiAe;Uid=root;Pwd=061289";
        private int lastSelectedThemenID;

        public ThemenScreen()
        {
            InitializeComponent();

            ShowThemen();
            LoadLF();
        }

        private void btnRtnThemen2Menu_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.Show();
            this.Hide();
        }

        private void btnAddThemen_Click(object sender, EventArgs e)
        {
            if (txtBoxThemenBez.Text == ""
             || comboBoxChooseLF.Text == "")
            {
                MessageBox.Show("Bitte trage alle Daten für das Thema ein.");
                return;
            }


            // Über die gewählte LFBezeichnung erfolgt eine Abgfrage der LFID aus der Lernfelder-Tabelle.
            string selectedLF = comboBoxChooseLF.SelectedItem.ToString();

            int lfID;

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();

                string queryGetLFID = "SELECT LFID From Lernfelder WHERE LFBezeichnung = @LFBezeichnung";

                using (MySqlCommand cmd = new MySqlCommand(queryGetLFID, connection))
                {
                    cmd.Parameters.AddWithValue("@LFBezeichnung", selectedLF);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        lfID = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Kein passendes Lernfeld gefunden.");
                        return;
                    }
                }
            }

            string themaBez = txtBoxThemenBez.Text;
            string themaDatum = datePickerThema.Value.ToString("yyyy-MM-dd");

            string queryAddThema = "INSERT INTO Themen (Themenbezeichnung, Bearbeitungsdatum, LFID) " +
                "VALUES (@Themenbezeichnung, @Bearbeitungsdatum, @LFID)";

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryAddThema, connection))
                {
                    cmd.Parameters.AddWithValue("@Themenbezeichnung", themaBez);
                    cmd.Parameters.AddWithValue("@Bearbeitungsdatum", themaDatum);
                    cmd.Parameters.AddWithValue("@LFID", lfID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Lernfeld eingetragen.");
                ShowThemen();
                ClearFields();
            }
        }

        private void btnDeleteThemen_Click(object sender, EventArgs e)
        {
            if (lastSelectedThemenID == 0)
            {
                MessageBox.Show("Bitte wähle zunächst ein Thema aus.");
                return;
            }

            string queryDeleteThema = "DELETE FROM Themen WHERE ThemenID = @ThemenID";

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryDeleteThema, connection))
                {
                    cmd.Parameters.AddWithValue("@ThemenID", lastSelectedThemenID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Das Thema wurde entfernt.");
            ShowThemen();
            ClearFields();
        }

        private void btnEditThemen_Click(object sender, EventArgs e)
        {
            if (lastSelectedThemenID == 0)
            {
                MessageBox.Show("Bitte wähle zunächst ein Thema aus.");
                return;
            }

            string selectedLF = comboBoxChooseLF.SelectedItem.ToString();

            int lfID;

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();

                string queryGetLFID = "SELECT LFID From Lernfelder WHERE LFBezeichnung = @LFBezeichnung";

                using (MySqlCommand cmd = new MySqlCommand(queryGetLFID, connection))
                {
                    cmd.Parameters.AddWithValue("@LFBezeichnung", selectedLF);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        lfID = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Kein passendes Lernfeld gefunden.");
                        return;
                    }
                }
            }

            string themaBez = txtBoxThemenBez.Text;
            string themaDatum = datePickerThema.Value.ToString("yyyy-MM-dd");

            string queryEditThema = "UPDATE Themen SET " +
                "Themenbezeichnung = @Themenbezeichnung, Bearbeitungsdatum = @Bearbeitungsdatum, LFID = @LFID " +
                "WHERE ThemenID = @ThemenID";

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryEditThema, connection))
                {
                    cmd.Parameters.AddWithValue("@Themenbezeichnung", themaBez);
                    cmd.Parameters.AddWithValue("@Bearbeitungsdatum", themaDatum);
                    cmd.Parameters.AddWithValue("@LFID", lfID);
                    cmd.Parameters.AddWithValue("@ThemenID", lastSelectedThemenID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Änderungen am Thema vorgenommen.");
            ShowThemen();
            ClearFields();
        }

        private void btnClearThemen_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewShowThemen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBoxThemenBez.Text = dataGridViewShowThemen.SelectedRows[0].Cells[1].Value.ToString();
                datePickerThema.Value = DateTime.Parse(dataGridViewShowThemen.SelectedRows[0].Cells[2].Value.ToString());
                comboBoxChooseLF.Text = dataGridViewShowThemen.SelectedRows[0].Cells[3].Value.ToString();
                lastSelectedThemenID = Convert.ToInt32(dataGridViewShowThemen.SelectedRows[0].Cells[0].Value);
            }
        }

        private void ShowThemen()
        {
            string queryShowThemen = "SELECT t.ThemenID, t.Themenbezeichnung, t.Bearbeitungsdatum, l.LFBezeichnung FROM Themen t " +
                "JOIN Lernfelder l ON t.LFID = l.LFID";

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(queryShowThemen, databaseConnection);

                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);

                dataGridViewShowThemen.DataSource = dataSet.Tables[0];
                dataGridViewShowThemen.Columns[0].Visible = false;
            }
        }

        private void ClearFields()
        {
            txtBoxThemenBez.Clear();
        }

        // Zeigt in der comboBox die Lernfeldbezeichnungen aus der Lernfelder-Tabelle und lässt diese auswählen.
        private void LoadLF()
        {
            string queryShowLF = "SELECT LFBezeichnung FROM Lernfelder";

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            using (MySqlCommand cmd = new MySqlCommand(queryShowLF, connection))
            {
                connection.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    comboBoxChooseLF.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxChooseLF.Items.Add(reader["LFBezeichnung"].ToString());
                    }
                }
            }
        }
    }
}
