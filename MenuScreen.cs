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
    public partial class MenuScreen : Form
    {
        private string _dbUserName;
        
        public MenuScreen(string dbUserName)
        {
            InitializeComponent();

            _dbUserName = dbUserName;
        }

        private void btnWritingScreen_Click(object sender, EventArgs e)
        {
            ChooseWritingScreen writingScreen = new ChooseWritingScreen(_dbUserName);
            writingScreen.Show();
            this.Hide();
        }

        private void btnReadingScreen_Click(object sender, EventArgs e)
        {
            ReadingScreen readingScreen = new ReadingScreen(_dbUserName);
            readingScreen.Show();
            this.Hide();
        }

        private void btnRtnLoginScreen_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
