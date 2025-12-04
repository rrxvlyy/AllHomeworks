using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces2
{
    internal class Weapon : Item, IEquipable
    {
        public Weapon(string name, string description) : base("Оружие", "Экипируется")
        {

        }


        public void Equip(Character user)
        {
            user.EquipWeapon(this as Weapon);
        }
    }
}
