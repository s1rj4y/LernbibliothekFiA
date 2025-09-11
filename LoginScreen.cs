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
using System.Text.RegularExpressions;

namespace LernbibliothekFiA
{
    public partial class LoginScreen : Form
    {
        private string dbUserConnection = "Server=127.0.0.1;Port=3306;Database=user_lernbibliothek;Uid=root;Pwd=061289";

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnUserCreate_Click(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == "Benutzername" 
                || txtBoxUserName.Text == ""
                || txtBoxUserPW.Text == "Passwort"
                || txtBoxUserPW.Text == "")
            {
                MessageBox.Show("Bitte gib deinen Benutzernamen und dein Passwort ein.");
                return;
            }

            string userName = txtBoxUserName.Text;
            string userPW = txtBoxUserPW.Text;

            string queryUserCheck = "SELECT COUNT(*) FROM user_bib WHERE username = @username";
            string queryUserCreate = "INSERT INTO user_bib (username, passwort) " +
                "VALUES (@username, @passwort)";

            using (MySqlConnection connection = new MySqlConnection(dbUserConnection))
            {
                connection.Open();

                using (MySqlCommand cmd =  new MySqlCommand(queryUserCheck, connection))
                {
                    cmd.Parameters.AddWithValue("@username", userName);
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Der Benutzer ist bereits registriert.");
                        return;
                    }
                }
                 
                using (MySqlCommand cmd =  new MySqlCommand(queryUserCreate, connection))
                {                                     
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@passwort", userPW);
                    cmd.ExecuteNonQuery();
                }

                // Sicheren Datenbanknamen bauen.
                string rawDbName = $"{userName}_bib";
                string safeDbName = Regex.Replace(rawDbName, "[^a-zA-Z0-9_]", ""); //Regex. braucht using System.Text.RegularExpressions;

                if (string.IsNullOrWhiteSpace(safeDbName))
                {
                    safeDbName = "Benutzer_bib";
                }

                string queryUserDbCreate = $"CREATE DATABASE  `{safeDbName}`"; // `` = Backticks

                using (MySqlCommand cmd = new MySqlCommand(queryUserDbCreate, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                string queryTableLFCreate = $@"CREATE TABLE `{safeDbName}`.Lernfelder " +
                    "(LFID int unsigned not null auto_increment primary key," +
                    "LFNr int not null," +
                    "LFBezeichnung varchar(100) not null, " +
                    "Startdatum date," +
                    "LFBeschreibung varchar(1500) not null);";

                using (MySqlCommand cmd = new MySqlCommand(queryTableLFCreate, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                string queryEmptyLF = $@"INSERT INTO `{safeDbName}`.Lernfelder 
                     (LFNr, LFBezeichnung, LFBeschreibung) VALUES (@lfNr, @lfBez, @lfBeschr)";

                using (MySqlCommand cmd = new MySqlCommand(queryEmptyLF, connection))
                {
                    cmd.Parameters.AddWithValue("@lfNr", 0);
                    cmd.Parameters.AddWithValue("@lfBez", "/");
                    cmd.Parameters.AddWithValue("@lfBeschr", "/");
                    cmd.ExecuteNonQuery();
                }

                string queryTableThemenCreate = $@"CREATE TABLE `{safeDbName}`.Themen " +
                    "(ThemenID int unsigned not null auto_increment primary key," +
                    "Themenbezeichnung varchar(100) not null," +
                    "Bearbeitungsdatum date," +
                    "LFID int unsigned not null);";

                using (MySqlCommand cmd = new MySqlCommand(queryTableThemenCreate, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                string queryEmptyThema = $@"INSERT INTO `{safeDbName}`.Themen (Themenbezeichnung, LFID) VALUES (@thema, @lfID)";

                using (MySqlCommand cmd = new MySqlCommand(queryEmptyThema, connection))
                {
                    cmd.Parameters.AddWithValue("@thema", "/");
                    cmd.Parameters.AddWithValue("@lfID", 1);
                    cmd.ExecuteNonQuery();
                }

                string queryTableGKCreate = $@"CREATE TABLE `{safeDbName}`.Grundkompetenzen " +
                    "(GKID int unsigned not null auto_increment primary key," +
                    "GKNr int not null," +
                    "GKBezeichnung varchar(100) not null," +
                    "Bearbeitungsdatum date," +
                    "LFID int unsigned not null);";

                using (MySqlCommand cmd = new MySqlCommand(queryTableGKCreate, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                string queryEmptyGK = $@"INSERT INTO `{safeDbName}`.Grundkompetenzen 
                    (GKNr, GKBezeichnung, LFID) VALUES (@gkNr, @gk, @lfID)";

                using (MySqlCommand cmd = new MySqlCommand(queryEmptyGK, connection))
                {
                    cmd.Parameters.AddWithValue("@gkNr", 0);
                    cmd.Parameters.AddWithValue("@gk", "/");
                    cmd.Parameters.AddWithValue("@lfID", 1);
                    cmd.ExecuteNonQuery();
                }

                string queryTableBegriffeCreate = $@"CREATE TABLE `{safeDbName}`.Begriffe " +
                    "(BegriffID int unsigned not null auto_increment primary key," +
                    "Begriffbezeichnung varchar(100) not null," +
                    "Begriffsdefinition varchar(2000) not null," +
                    "ThemenID int unsigned not null," +
                    "GKID int unsigned not null);";

                using (MySqlCommand cmd = new MySqlCommand(queryTableBegriffeCreate, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Benutzer angelegt und Datenbank erstellt.");
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            string userName = txtBoxUserName.Text;
            string userPW = txtBoxUserPW.Text;

            string queryCheckUserReg = "SELECT COUNT(*) FROM user_bib WHERE username = @username AND passwort = @passwort;";

            using (MySqlConnection connection = new MySqlConnection(dbUserConnection))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryCheckUserReg, connection)) 
                {
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@passwort", userPW);
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount == 0)
                    {
                        MessageBox.Show("Benutzername oder Passwort nicht korrekt eingetragen.");
                        return;
                    }
                }
            }

            string dbUserName = $"{userName}_bib";

            MenuScreen menuScreen = new MenuScreen(dbUserName);
            menuScreen.Show();
            this.Hide();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == "Benutzername"
                || txtBoxUserName.Text == ""
                || txtBoxUserPW.Text == "Passwort"
                || txtBoxUserPW.Text == "")
            {
                MessageBox.Show("Bitte gib deinen Benutzernamen und dein Passwort ein.");
                return;
            }

            string userName = txtBoxUserName.Text;
            string userPW = txtBoxUserPW.Text;
            string userDbName = $"{userName}_bib";

            string queryUserCheckSpelling = "SELECT COUNT(*) FROM user_bib WHERE username = @username AND passwort = @passwort;";

            string queryUserDelete = "DELETE FROM user_bib WHERE username = @username AND passwort = @passwort;";
            string queryUserDbDelete = $"DROP DATABASE `{userDbName}`";

            using (MySqlConnection connection = new MySqlConnection(dbUserConnection))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryUserCheckSpelling, connection))
                {
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@passwort", userPW);
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount == 0)
                    {
                        MessageBox.Show("Benutzername oder Passwort nicht korrekt eingetragen.");
                        return;
                    }
                }

                using (MySqlCommand cmd = new MySqlCommand(queryUserDelete, connection))
                {
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@passwort", userPW);
                    cmd.ExecuteNonQuery();
                }

                using (MySqlCommand cmd = new MySqlCommand(queryUserDbDelete, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Das Profil wurde entfernt.");
        }

        private void txtBoxUserName_Enter(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == "Benutzername")
            {
                txtBoxUserName.Text = "";
            }
        }

        private void txtBoxUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUserName.Text))
            {
                txtBoxUserName.Text = "Benutzername";
            }
        }

        private void txtBoxUserPW_Enter(object sender, EventArgs e)
        {
            if (txtBoxUserPW.Text == "Passwort")
            {
                txtBoxUserPW.Text = "";
                txtBoxUserPW.UseSystemPasswordChar = true;
            }
        }

        private void txtBoxUserPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUserPW.Text))
            {
                txtBoxUserPW.UseSystemPasswordChar = false;
                txtBoxUserPW.Text = "Passwort";
            }
        }


        // Verhindert, dass txtBoxUserName automatisch angewählt wird.
        private void LoginScreen_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
