using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces2
{
    internal class Item
    {
        private string name;
        private string description;
        public string Name {  get { return name; } }
        public string Description { get { return description; } }


        public virtual void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Description);
        }


        public Item(string name, string description)
        {
            this.name = name;
            this.description = description;
        }


        
    }
}
