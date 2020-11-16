using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class StrengthIncrease : Item
    {
        public int STRAmount { get; private set; }
        public Image Img { get; set; }
        public StrengthIncrease()
        {
            ID = 1002;
            Name = "StrengthUp";
            STRAmount = 2;
            MaxNumberOfItems = 20;
        }
        // Configure How this method is used
        public override int Use()
        {
            int returnVal = -1;
            if (Game.player.CharacterTemplate.Strength < 1000)
            {
                Game.player.AlterStrength(this.STRAmount);
                returnVal = 0;
            }
            return returnVal;
        }
    }
}
