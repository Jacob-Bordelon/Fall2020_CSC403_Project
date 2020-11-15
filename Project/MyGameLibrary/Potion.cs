using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class Potion : Item
    {
        public int HPAmount { get; private set; }
        public Image Img { get; set; }
        public Potion()
        {
            ID = 1001;
            Name = "Potion";
            HPAmount = 2;
            MaxNumberOfItems = 20;
        }
        // Configure How this method is used
        public override int Use()
        {
            int returnVal = -1;
            if (Game.player.Health < Game.player.MaxHealth)
            {
                Game.player.AlterHealth(this.HPAmount);
                returnVal = 0;
            }
            return returnVal;
        }
    }
}
