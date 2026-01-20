using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochnolast
{
    public class Accessory : Item
    {
        public int StrengthBonus { get; set; }
        public int IntelligenceBonus { get; set; }
        public int HealthBonus { get; set; }

        public Accessory(string name) : base(name)
        {
            StrengthBonus = 0;
            IntelligenceBonus = 0;
            HealthBonus = 0;
        }

        public Accessory(string name, int strength, int intelligence, int health) : base(name)
        {
            StrengthBonus = strength;
            IntelligenceBonus = intelligence;
            HealthBonus = health;
        }
    }
}
