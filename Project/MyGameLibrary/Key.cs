using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class Key : Item
    {
        public int DoorID { get; private set; }
        public Image Img { get; set; }
        public Key()
        {
            ID = 1000;
            Name = "Key";
            DoorID = 2000;
            MaxNumberOfItems = 3;
        }

        // Configure How this method is used
        public override int Use()
        {
            return -1;
        }
    }
}
