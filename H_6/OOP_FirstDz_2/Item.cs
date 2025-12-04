using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FirstDz_2
{
    internal class Item
    {
        private string name;
        private int damage;
        private float weight;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Damage
        {
            get
            {
                return damage;
            }
        }
        public float Weight
        {
            get
            {
                return weight;
            }
        }
        public Item(string name, int damage, float weight)
        {
            this.name = name;
            this.damage = damage;
            this.weight = weight;
        }
        public void Info_Item(Item item)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Damage);
            Console.WriteLine(item.Weight);
        }

    }
}
