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
        const int MaxNumberSlots = 24;
        public List<Entry> InventoryList;
        public Inventory()
        {
            InventoryList = new List<Entry>();
        }
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
