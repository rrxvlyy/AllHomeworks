using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces2
{
    internal class Gem : Item, ISellable
    {
        public Gem(string name, string description) : base("Драгоценный камень", "Меняет кол-во золота")
        {

        }

        public int Price { get; } = 20;

        public void Sell(Character user)
        {

            user.AddGold(Price);
            Inventory.RemoveItem(this);
        }
    }
}
