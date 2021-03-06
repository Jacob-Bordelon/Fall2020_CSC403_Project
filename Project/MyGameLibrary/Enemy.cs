﻿using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// This is the class for an enemy
    /// </summary>
    public class Enemy : BattleCharacter
    {
        /// <summary>
        /// THis is the image for an enemy
        /// </summary>
        public Image Img { get; set; }

        private PictureBox _picbox;


        /// <summary>
        /// this is the number of enemies in the game
        /// </summary>
        public static int num=0;
        /// <summary>
        /// this is the background color for the fight form for this enemy
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initPos">this is the initial position of the enemy</param>
        /// <param name="collider">this is the collider for the enemy</param>
        public Enemy(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            
            num++;
        }

        public PictureBox picbox {
            get { return this._picbox; }
            set
            {
                this._picbox = value;
                this.Img = this._picbox.BackgroundImage;

            }
                 
        }

        public void destroy()
        {
            
            num--;
        }
    }
}
