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
    }
}
