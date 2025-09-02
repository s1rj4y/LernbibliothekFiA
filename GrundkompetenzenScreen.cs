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
        public GrundkompetenzenScreen()
        {
            InitializeComponent();
        }

        private void btnRtnGK2Menu_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.Show();
            this.Hide();
        }
    }
}
