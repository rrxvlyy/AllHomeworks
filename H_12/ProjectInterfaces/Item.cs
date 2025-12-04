using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces
{
    internal class Item
    {
        private string name;
        private string description;
        private int count;

        public string Name {  get { return name; } }
        public string Description { get { return description; } }
        public int Count { get { return count; } set { count = value; } }

        public virtual void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine(Count);
        }


        public Item(string name, string description, int count)
        {
            this.name = name;
            this.description = description;
            this.count = count;
        }
    }
}
