using System;
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
            HPAmount = 10;
            MaxNumberOfItems = 20;
        }
    }
}
