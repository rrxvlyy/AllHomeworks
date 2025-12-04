using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces2
{
    internal class Inventory
    {
        public static List<Item> listItems;
        private int maxCountItems;

        public int MaxCountItems {  get { return maxCountItems; } }


        public Inventory(int maxCountItems)
        {
            listItems = new List<Item>(maxCountItems);
        }


        public void Add(Item item)
        {
            listItems.Add(item);
        }


        public void RemoveAt(int index)
        {
            if ((index < 0) || (index >= listItems.Count))
            {
                Console.WriteLine("Ошибка! Индекс вышел за рамки списка");
            }
            else
            {
                listItems[index] = null;
            }
        }


        public static Item GetItem(int index)
        {
            if ((index < 0) || (index >= listItems.Count))
            {
                Console.WriteLine("Ошибка! Индекс вышел за рамки списка");
                return null;
            }
            else
            {
                return listItems[index];
            }
        }


        public void ShowInventory()
        {
            Console.WriteLine("--- СОДЕРЖИМОЕ ИНВЕНТАРЯ ---");
            for(int i = 0; i < listItems.Count; i++)
            {
                Console.WriteLine($"{i} - {listItems[i].Name} - {listItems[i].Description}");
            }
        }

        public static void RemoveItem(Item item)
        {
            listItems.Remove(item);
        }
    }
}
