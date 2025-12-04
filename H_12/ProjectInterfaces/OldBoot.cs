using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces
{
    internal class OldBoot : Item, IDiscardable
    {
        public OldBoot(string name, string description) : base("Старый ботинок", "Выкидывается :/", 1)
        {

        }


        public void Discard()
        {
            Console.WriteLine("Ботинок выкинут");
            Inventory.RemoveItem(this);
        }
    }
}
