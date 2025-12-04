using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces
{
    internal class MagicRing: Item, IEquipable, ISellable
    {
        public int Price { get; } = 20;

        public MagicRing(string name, string description) : base("Магическое кольцо", "Экипируется и меняет кол-во золота", 1)
        {

        }

        public void Equip(Character user)
        {
            user.EquipRing(this as MagicRing);
        }


        public void Sell(Character user)
        {
            user.AddGold(Price);
        }
    }
}
