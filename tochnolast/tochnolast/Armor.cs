using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochnolast
{
    public class Armor : Item
    {
        public int Defense { get; set; }
        public ArmorType Type { get; set; }
        public int StrengthBonus { get; set; }
        public int IntelligenceBonus { get; set; }

        public Armor(string name, ArmorType type, int defense) : base(name)
        {
            Type = type;
            Defense = defense;
            StrengthBonus = 0;
            IntelligenceBonus = 0;
        }

        public Armor(string name, ArmorType type, int defense, int strength, int intelligence) : base(name)
        {
            Type = type;
            Defense = defense;
            StrengthBonus = strength;
            IntelligenceBonus = intelligence;
        }
    }
}
