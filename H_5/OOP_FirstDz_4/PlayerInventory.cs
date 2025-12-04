using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FirstDz_4
{
    internal class PlayerInventory
    {
        private Item[] items;
        private float weightCapacity;
        public float WeightCapacity
        {
            get
            {
                return weightCapacity;
            }
        }
        public PlayerInventory(float weightCapacity, int massive_size)
        {
            this.weightCapacity = weightCapacity;
            items = new Item[massive_size];
        }
        public bool AddItem(Item item)
        {
            int null_index = -1;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    null_index = i;
                    break;
                }
            }
            if (null_index == -1)
            {
                Console.WriteLine("Ошибка, инвентарь полон");
                return false;
            }
            float total_weight = GetTotalWeight();
            if (weightCapacity - total_weight < item.Weight)
            {
                Console.WriteLine("Ошибка, нет места для предмета");
                return false;
            }
            items[null_index] = item;
            return true;
        }
        public float GetTotalWeight()
        {
            float totalweight = 0;
            foreach(Item item in items)
            {
                if (item != null)
                {
                    totalweight += item.Weight;
                }
            }
            return totalweight;
        }

    }
}
