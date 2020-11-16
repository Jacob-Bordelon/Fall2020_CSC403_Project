using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class MaxHP : Item
    {
        public Image Img { get; set; }
        public MaxHP()
        {
            ID = 1005;
            Name = "MaxHP";
            MaxNumberOfItems = 20;
        }
        // Configure How this method is used
        public override int Use()
        {
            int returnVal = -1;
            if (Game.player.Health < Game.player.CharacterTemplate.MaxHealth)
            {
                Game.player.SetHPValues();
                returnVal = 0;
            }
            return returnVal;


        }
    }
}
