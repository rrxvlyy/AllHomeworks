using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces2
{
    internal class Armor : Item, IEquipable
    {
        public Armor(string name, string description) : base("Броня", "Экипируется")
        {

        }


        public void Equip(Character user)
        {
            user.EquipArmor(this as Armor);
        }
    }
}
