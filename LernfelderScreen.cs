using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace LernbibliothekFiA
{      
    public partial class LernfelderScreen : Form
    {
        private string _dbUserName;
        private int lastSelectedLFID;

        public LernfelderScreen(string dbUserName)
        {
            InitializeComponent();

            _dbUserName = dbUserName;

            ShowLF();
        }

        private void btnRtnLF2Menu_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen(_dbUserName);
            menuScreen.Show();
            this.Hide();
        }

        private void btnAddLF_Click(object sender, EventArgs e)
        {
            if (txtBoxLFNr.Text == "" 
             || txtBoxLFBez.Text == "" 
             || richTextBoxLFBeschr.Text == "")
            {
                MessageBox.Show("Bitte trage alle Daten des Lernfelds ein.");
                return;
            }

            string lfNr = txtBoxLFNr.Text;
            string lfBez = txtBoxLFBez.Text;
            string lfDatum = datePickerLF.Value.ToString("yyyy-MM-dd"); 
            string lfBeschr = richTextBoxLFBeschr.Text;

            string queryAddLF = "INSERT INTO Lernfelder (LFNr, LFBezeichnung, Startdatum, LFBeschreibung) " +
                "VALUES (@LFNr, @LFBezeichnung, @Startdatum, @LFBeschreibung)";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryAddLF, connection))
                {
                    if (!int.TryParse(txtBoxLFNr.Text, out int lfNR))
                    {
                        MessageBox.Show("Die eingetragene Lernfeldnummer ist keine Nummer.");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@LFNr", lfNr);                      
                    cmd.Parameters.AddWithValue("@LFBezeichnung", lfBez);
                    cmd.Parameters.AddWithValue("@Startdatum", lfDatum);
                    cmd.Parameters.AddWithValue("@LFBeschreibung", lfBeschr);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Lernfeld eingetragen.");
                ShowLF();
                ClearFields();
            }
        }

        private void btnDeleteLF_Click(object sender, EventArgs e)
        {
            if (lastSelectedLFID == 0)
            {
                MessageBox.Show("Bitte wähle zunächst ein Lernfeld aus.");
                return;
            }

            string queryDeleteLF = "DELETE FROM Lernfelder WHERE LFID = @LFID";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryDeleteLF, connection))
                {
                    cmd.Parameters.AddWithValue("@LFID", lastSelectedLFID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Das Lernfeld wurde entfernt.");
            ShowLF();
            ClearFields();
        }

        private void btnEditLF_Click(object sender, EventArgs e)
        {
            if (lastSelectedLFID == 0)
            {
                MessageBox.Show("Bitte wähle zunächst ein Lernfeld aus.");
                return;
            }

            string lfNr = txtBoxLFNr.Text;
            string lfBez = txtBoxLFBez.Text;
            string lfDatum = datePickerLF.Value.ToString("yyyy-MM-dd");
            string lfBeschr = richTextBoxLFBeschr.Text;

            string queryEditLF = "UPDATE Lernfelder SET " +
                "LFNr = @LFNr, LFBezeichnung = @LFBezeichnung, Startdatum = @Startdatum, LFBeschreibung = @LFBeschreibung " +
                "WHERE LFID = @LFID";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryEditLF, connection))
                {
                    cmd.Parameters.AddWithValue("@LFNr", lfNr);
                    cmd.Parameters.AddWithValue("@LFBezeichnung", lfBez);
                    cmd.Parameters.AddWithValue("@Startdatum", lfDatum);
                    cmd.Parameters.AddWithValue("@LFBeschreibung", lfBeschr);
                    cmd.Parameters.AddWithValue("@LFID", lastSelectedLFID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Änderungen am Lernfeld vorgenommen.");
            ShowLF();
            ClearFields();
        }

        private void btnClearLF_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Sorgt dafür, dass im DGV ausgewählte Elemente in die zugehörigen Zeilen der Maske übertragen werden.
        // Die Überschriftenzeile lässt sich dabei nicht anklicken.
        private void dataGridViewShowLF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBoxLFNr.Text = dataGridViewShowLF.SelectedRows[0].Cells[1].Value.ToString();
                txtBoxLFBez.Text = dataGridViewShowLF.SelectedRows[0].Cells[2].Value.ToString();
                datePickerLF.Value = DateTime.Parse(dataGridViewShowLF.SelectedRows[0].Cells[3].Value.ToString());
                richTextBoxLFBeschr.Text = dataGridViewShowLF.SelectedRows[0].Cells[4].Value.ToString();
                lastSelectedLFID = Convert.ToInt32(dataGridViewShowLF.SelectedRows[0].Cells[0].Value);
            }
        }

        // Zeigt die Daten der Lernfelder-Tabelle an.
        // LFID wird dabei nicht angezeigt.
        // Auch wird die erste Zeile ausgeblendet, weil diese lediglich einen Platzhaltereintrag enthält.
        private void ShowLF()
        {
            string queryShowLF = "SELECT * FROM Lernfelder";

            using (var connection = UserNameDbConnection.GetConnection(_dbUserName))
            {
                connection.Open();

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(queryShowLF, connection);

                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);

                DataTable table = dataSet.Tables[0];

                if (table.Rows.Count > 0)
                {
                    table.Rows[0].Delete();
                }

                dataGridViewShowLF.DataSource = table;
                dataGridViewShowLF.Columns[0].Visible = false;                
            }
        }

        // Leert alle Felder.
        private void ClearFields()
        {
            txtBoxLFNr.Clear();
            txtBoxLFBez.Clear();
            richTextBoxLFBeschr.Clear();
        }
    }
}
