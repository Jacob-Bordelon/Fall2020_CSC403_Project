using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Inventory
    {
        // Limits the number of slots in the invetory window
        const int MaxNumberSlots = 24;
        public List<Entry> InventoryList;
        public Inventory()
        {
            InventoryList = new List<Entry>();
        }
        // Adds an entry to the invetory list. If entry exists, it increases the quantity
        // It will limit the number of items according to the maximum permited by the item
        public void InsertEntry(Item item, int quantity)
        {
            if (InventoryList.Count < MaxNumberSlots)
            {
                if (InventoryList.Exists(x => (x.EntryItem.ID == item.ID)))
                {
                    foreach (Entry entry in InventoryList.ToList())
                    {
                        if (entry.EntryItem.ID == item.ID)
                        {
                            if ((entry.EntryQuantity + quantity) <= entry.EntryItem.MaxNumberOfItems)
                            {
                                entry.EntryQuantity += quantity;
                            }
                            else if ((entry.EntryQuantity + quantity) >= entry.EntryItem.MaxNumberOfItems)
                            {
                                entry.EntryQuantity = entry.EntryItem.MaxNumberOfItems;
                            }
                        }
                    }
                }
                else
                {
                    if(quantity >= item.MaxNumberOfItems)
                    {
                        InventoryList.Add(new Entry(item, item.MaxNumberOfItems));
                    }
                    else
                    {
                        InventoryList.Add(new Entry(item, quantity));
                    }
                        
                }
            }
            
        }
        // Finds the entry and removes it from the list to update the inventory
        public Item WithdrawEntry(int ID)
        {
            Item ItemToWithdraw = null;
            foreach (Entry entry in InventoryList.ToList())
            {
                if (entry.EntryItem.ID == ID)
                {
                    ItemToWithdraw = entry.EntryItem;
                    if ((entry.EntryQuantity - 1) <= 0)
                    {
                        InventoryList.Remove(entry);
                    }
                    else
                    {
                        entry.EntryQuantity -= 1;
                    }
                }
            }

            return ItemToWithdraw;
        }
        // Method to get the quantity of a certain item
        public int QuantityItem(int ID)
        {
            int QuantityItem = 0; 
            foreach (Entry entry in InventoryList.ToList())
            {
                if (entry.EntryItem.ID == ID)
                {
                    QuantityItem = entry.EntryQuantity;
                }
            }
            return QuantityItem;
        }
    }
    // Entry structure in order to keep track of number of items in the inventory
    public class Entry
    {
        public Item EntryItem { get; set; }
        public int EntryQuantity { get; set; }
        public Entry(Item item, int quantity)
        {
            EntryItem = item;
            EntryQuantity = quantity;
        }
    }
}
