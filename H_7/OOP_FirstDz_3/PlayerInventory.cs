using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FirstDz_3
{
    internal class PlayerInventory
    {
        Item[] items = new Item[1];
        int[] items_summ = new int[1];
        public Item[] AddItem(Item item)
        {
            int originalLength = items.Length;
            Array.Resize(ref items, originalLength + 1);
            items[originalLength] = item;
            return items;
        }
        public void GetTotalPrice(Item item)
        {
            int originalLength = items_summ.Length;
            Array.Resize(ref items_summ, originalLength + 1);
            items_summ[originalLength] = item.Price;
            int summ = 0;
            summ = items_summ.Sum();
            Console.WriteLine(summ);
        }
        public void WhatsOnInventory()
        {
            foreach (Item item in items)
            {
                if (item != null)
                {
                    item.Info_Item(item);
                }
            }
        }

    }
}
