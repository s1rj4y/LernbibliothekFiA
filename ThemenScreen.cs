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
        public ThemenScreen()
        {
            InitializeComponent();
        }

        private void btnRtnThemen2Menu_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.Show();
            this.Hide();
        }
    }
}
