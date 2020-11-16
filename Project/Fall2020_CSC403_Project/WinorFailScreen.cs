using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fall2020_CSC403_Project
{
    public partial class WinorFailScreen : Form
    {
        
        public WinorFailScreen(string type)
        {
            InitializeComponent();
            var display = this.pictureBox1;

            if(type == "win")
            {
                display.Image = new Bitmap(Properties.Resources.YouWin, display.Size);
            }
            else
            {
                display.Image = new Bitmap(Properties.Resources.YouLose,display.Size);
            }

        }



        private void PlayAgain(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void QuitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
