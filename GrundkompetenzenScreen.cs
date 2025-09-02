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
    public partial class GrundkompetenzenScreen : Form
    {
        private string databaseConnection = "Server=127.0.0.1;Port=3306;Database=Lernbibliothek_FiAe;Uid=root;Pwd=061289";
        private int lastSelectedGKID;

        public GrundkompetenzenScreen()
        {
            InitializeComponent();

            ShowGK();
            LoadLF();
        }

        private void btnRtnGK2Menu_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.Show();
            this.Hide();
        }

        private void btnAddGK_Click(object sender, EventArgs e)
        {
            if (txtBoxGKNr.Text == ""
             || txtBoxGKBez.Text == ""
             || comboBoxChooseLF.Text == "")
            {
                MessageBox.Show("Bitte trage alle Daten der Grundkompetenz ein.");
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

            string gkNr = txtBoxGKNr.Text;
            string gkBez = txtBoxGKBez.Text;
            string gkDatum = datePickerGK.Value.ToString("yyyy-MM-dd");

            string queryAddGK = "INSERT INTO Grundkompetenzen (GKNr, GKBezeichnung, Bearbeitungsdatum, LFID) " +
                "VALUES (@GKNr, @GKBezeichnung, @Bearbeitungsdatum, @LFID)";

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryAddGK, connection))
                {
                    if (!int.TryParse(txtBoxGKNr.Text, out int gkNR))
                    {
                        MessageBox.Show("Die eingetragene Grundkompetenznummer ist keine Nummer.");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@GKNr", gkNr);
                    cmd.Parameters.AddWithValue("@GKBezeichnung", gkBez);
                    cmd.Parameters.AddWithValue("@Bearbeitungsdatum", gkDatum);
                    cmd.Parameters.AddWithValue("@LFID", lfID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Grundkompetenz eingetragen.");
                ShowGK();
                ClearFields();
            }
        }

        private void btnDeleteGK_Click(object sender, EventArgs e)
        {
            if (lastSelectedGKID == 0)
            {
                MessageBox.Show("Bitte wähle zunächst eine Grundkompetenz aus.");
                return;
            }

            string queryDeleteGK = "DELETE FROM Grundkompetenzen WHERE GKID = @GKID";

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryDeleteGK, connection))
                {
                    cmd.Parameters.AddWithValue("@GKID", lastSelectedGKID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Die Grundkompetenz wurde entfernt.");
            ShowGK();
            ClearFields();
        }

        private void btnEditGK_Click(object sender, EventArgs e)
        {
            if (lastSelectedGKID == 0)
            {
                MessageBox.Show("Bitte wähle zunächst eine Grundkompetenz aus.");
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

            string gkNr = txtBoxGKNr.Text;
            string gkBez = txtBoxGKBez.Text;
            string gkDatum = datePickerGK.Value.ToString("yyyy-MM-dd");

            string queryEditGK = "UPDATE Grundkompetenzen SET " +
                "GKNr = @GKNr, GKBezeichnung = @GKBezeichnung, Bearbeitungsdatum = @Bearbeitungsdatum, LFID = @LFID " +
                "WHERE GKID = @GKID";

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryEditGK, connection))
                {
                    cmd.Parameters.AddWithValue("@GKNr", gkNr);
                    cmd.Parameters.AddWithValue("@GKBezeichnung", gkBez);
                    cmd.Parameters.AddWithValue("@Bearbeitungsdatum", gkDatum);
                    cmd.Parameters.AddWithValue("@LFID", lfID);
                    cmd.Parameters.AddWithValue("@GKID", lastSelectedGKID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Änderungen an der Grundkompetenz vorgenommen.");
            ShowGK();
            ClearFields();
        }

        private void btnClearGK_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewShowGK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBoxGKNr.Text = dataGridViewShowGK.SelectedRows[0].Cells[1].Value.ToString();
                txtBoxGKBez.Text = dataGridViewShowGK.SelectedRows[0].Cells[2].Value.ToString();
                datePickerGK.Value = DateTime.Parse(dataGridViewShowGK.SelectedRows[0].Cells[3].Value.ToString());
                comboBoxChooseLF.Text = dataGridViewShowGK.SelectedRows[0].Cells[4].Value.ToString();
                lastSelectedGKID = Convert.ToInt32(dataGridViewShowGK.SelectedRows[0].Cells[0].Value);
            }
        }

        private void ShowGK()
        {
            string queryShowGK = "SELECT g.GKID, g.GKNr, g.GKBezeichnung, g.Bearbeitungsdatum, l.LFBezeichnung " +
                "FROM Grundkompetenzen g JOIN Lernfelder l ON g.LFID = l.LFID";

            //string queryShowThemen = "SELECT t.ThemenID, t.Themenbezeichnung, t.Bearbeitungsdatum, l.LFBezeichnung " +
            //    "FROM Themen t JOIN Lernfelder l ON t.LFID = l.LFID";

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(queryShowGK, databaseConnection);

                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);

                dataGridViewShowGK.DataSource = dataSet.Tables[0];
                dataGridViewShowGK.Columns[0].Visible = false;
            }
        }

        private void ClearFields()
        {
            txtBoxGKNr.Clear();
            txtBoxGKBez.Clear();
        }

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
