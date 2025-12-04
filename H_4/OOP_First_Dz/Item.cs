using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP_First_Dz
{
    internal class Item
    {
        private string name;
        private int price;
        private float weight;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
        }
        public float Weight
        {
            get
            {
                return weight;
            }
        }
        public Item(string name, int price, float weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Имя:" + Name);
            Console.WriteLine("Цена:" + Price);
            Console.WriteLine("Вес:" + Weight);
        }
    }
}
