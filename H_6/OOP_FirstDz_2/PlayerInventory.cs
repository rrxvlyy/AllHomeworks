using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FirstDz_2
{
    internal class PlayerInventory
    {
        Item[] items = new Item[0];
        public Item[] AddItem(Item item)
        {
            int originalLength = items.Length;
            Array.Resize(ref items, originalLength + 1);
            items[originalLength] = item;
            return items;
        }

        public void WhatsOnInventory()
        {
            foreach(Item item in items)
            {
                if (item != null)
                {
                    item.Info_Item(item);
                }
            }
        }

    }
}
