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
    public partial class ChooseWritingScreen : Form
    {
        public ChooseWritingScreen()
        {
            InitializeComponent();
        }

        private void btnChooseLF_Click(object sender, EventArgs e)
        {
            LernfelderScreen lfScreen = new LernfelderScreen();
            lfScreen.Show();
            this.Hide();
        }

        private void btnChooseThemen_Click(object sender, EventArgs e)
        {
            ThemenScreen themenScreen = new ThemenScreen();
            themenScreen.Show();
            this.Hide();
        }

        private void btnChooseGK_Click(object sender, EventArgs e)
        {
            GrundkompetenzenScreen gkScreen = new GrundkompetenzenScreen();
            gkScreen.Show();
            this.Hide();
        }

        private void btnChooseBegriffe_Click(object sender, EventArgs e)
        {
            BegriffeScreen begriffeScreen = new BegriffeScreen();
            begriffeScreen.Show();
            this.Hide();
        }
    }
}
