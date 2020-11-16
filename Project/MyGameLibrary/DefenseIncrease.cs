using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class DefenseIncrease : Item
    {
        public int DEFAmount { get; private set; }
        public Image Img { get; set; }
        public DefenseIncrease()
        {
            ID = 1004;
            Name = "DefenseUP";
            DEFAmount = 1;
            MaxNumberOfItems = 20;
        }
        // Configure How this method is used
        public override int Use()
        {
            int returnVal = -1;
            if (Game.player.CharacterTemplate.Defense < 1000)
            {
                Game.player.CharacterTemplate.AlterDefense(this.DEFAmount);
                returnVal = 0;
            }
            return returnVal;
        }
    }
}

