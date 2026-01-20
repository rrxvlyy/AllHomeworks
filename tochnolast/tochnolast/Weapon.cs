using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochnolast
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public int StrengthBonus { get; set; }
        public int IntelligenceBonus { get; set; }

        public Weapon(string name, int damage) : base(name)
        {
            Damage = damage;
            StrengthBonus = 0;
            IntelligenceBonus = 0;
        }

        public Weapon(string name, int damage, int strength, int intelligence) : base(name)
        {
            Damage = damage;
            StrengthBonus = strength;
            IntelligenceBonus = intelligence;
        }
    }
}
