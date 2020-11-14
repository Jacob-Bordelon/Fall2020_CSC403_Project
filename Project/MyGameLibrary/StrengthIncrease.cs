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
        }
}
