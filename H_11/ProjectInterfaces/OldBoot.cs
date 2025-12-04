using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces2
{
    internal class OldBoot : Item, IDiscardable
    {
        public OldBoot(string name, string description) : base("Старый ботинок", "Выкидывается :/")
        {

        }


        public void Discard()
        {
            Console.WriteLine("Ботинок выкинут");
            Inventory.RemoveItem(this);
        }
    }
}
