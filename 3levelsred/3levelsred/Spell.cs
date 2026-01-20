using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3levelsred
{
    internal class Spell
    {
        public string Name { get; }
        public int Power { get; }
        public int Cooldown { get; }
        public int RemainingCooldown { get; private set; }

        public Spell(string name, int power, int cooldown)
        {
            Name = name;
            Power = power;
            Cooldown = cooldown;
            RemainingCooldown = 0;
        }

        public bool CanUse() => RemainingCooldown == 0;

        public void Use()
        {
            RemainingCooldown = Cooldown;
        }

        public void ReduceCooldown()
        {
            if (RemainingCooldown > 0)
                RemainingCooldown--;
        }
    }
}
