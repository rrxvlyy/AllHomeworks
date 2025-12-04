using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FirstDz_4
{
    internal class Item
    {
        private string name;
        private float weight;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public float Weight
        {
            get
            {
                return weight;
            }
        }
        public Item(string name, float weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
}
