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
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void btnWritingScreen_Click(object sender, EventArgs e)
        {
            ChooseWritingScreen writingScreen = new ChooseWritingScreen();
            writingScreen.Show();
            this.Hide();
        }

        private void btnReadingScreen_Click(object sender, EventArgs e)
        {
            ReadingScreen readingScreen = new ReadingScreen();
            readingScreen.Show();
            this.Hide();
        }
    }
}
