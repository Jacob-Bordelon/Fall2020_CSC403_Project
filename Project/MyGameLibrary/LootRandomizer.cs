using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class LootRandomizer {
        private readonly Random random = new Random();
        private readonly Loot potion = new Loot(new Potion(), 50);
        private readonly Loot strength = new Loot(new StrengthIncrease(), 30);
        private readonly Loot maxHP = new Loot(new MaxHPIncrease(), 20);
        private int randomNumber;
        private Item randomItem;
        public LootRandomizer() {
        }
        // Goes through the loot structure 
        public Item GetRandomItem() {
            Loot[] loot = { potion, strength, maxHP };
            randomNumber = random.Next(0, 100);
            foreach(Loot option in loot) {
                if(randomNumber <= option.LootDropRate) {
                    randomItem = option.LootItem;
                    return randomItem;
                }
                else {
                    randomNumber -= option.LootDropRate;
                }
            }

            return randomItem;
        }

    }
    public class Loot
    {
        public Item LootItem { get; set; }
        public int LootDropRate { get; set; }
        public Loot(Item item, int rate)
        {
            LootItem = item;
            LootDropRate = rate;
        }
    }
}
