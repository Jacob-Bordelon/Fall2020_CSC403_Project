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
        // Type of loot items to randomize with weights (DropRate)
        private readonly Loot potion = new Loot(new Potion(), 40);
        private readonly Loot strength = new Loot(new StrengthIncrease(), 30);
        private readonly Loot maxHPIncrease = new Loot(new MaxHPIncrease(), 10);
        private readonly Loot defense = new Loot(new DefenseIncrease(), 10);
        private readonly Loot maxHP = new Loot(new DefenseIncrease(), 10);

        private int randomNumber;
        private Item randomItem;
        public LootRandomizer() {
        }
        // Goes through array of loot objects 
        // It will through a random number between 0 and 100, and compares it to the droprate
        public Item GetRandomItem() {
            Loot[] loot = { potion, strength, maxHPIncrease, defense, maxHP };
            randomItem = new Potion();
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
    // Loot structure to hold the item with its droprate
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
