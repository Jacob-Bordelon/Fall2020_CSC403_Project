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
    /// <summary>
    /// Create a screen that can either signify a win or loss
    /// </summary>
    public partial class WinorFailScreen : Form
    {
        /// <summary>
        /// Initialize the screen
        /// </summary>
        /// <param name="type">Indicate whether the screen is 'win' or 'loss' to determine the type of screen.</param>
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


        /// <summary>
        /// When the play again button is pressed, restart the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayAgain(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// When the quit game button is pressed, quit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
