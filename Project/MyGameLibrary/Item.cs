using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public abstract class Item
    {
        /// <summary>
        /// Key=1000, Potion=1001, StrenghtIncrease=1002, IncreaseMaxHP=1003, DefenseIncrease=1004
        /// </summary>
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxNumberOfItems { get; set; }
        public Item()
        {
        }

        public abstract int Use();
        
    }
}
