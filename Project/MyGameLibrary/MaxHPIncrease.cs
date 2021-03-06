﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class MaxHPIncrease : Item
    {
        public int HPAmount { get; private set; }
        public Image Img { get; set; }
        public MaxHPIncrease()
        {
            ID = 1003;
            Name = "MaxHPUp";
            HPAmount = 5;
            MaxNumberOfItems = 20;
        }
        // Configure How this method is used
        public override int Use()
        {
            int returnVal = -1;
            if (Game.player.CharacterTemplate.MaxHealth < 1000)
            {
                Game.player.CharacterTemplate.AlterHealthPerLevel(this.HPAmount);
                Game.player.AlterHealth(this.HPAmount);

                returnVal = 0;
            }
            return returnVal;


        }
    }
}
