using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class Fireball : Spell
    {
        public int Damage;
        public Fireball(string name, string spell_info) : base(name, spell_info)
        {
            name = "Огненый мяч";
            spell_info = "Урон огнем";
        }
        public override void Apply(Character goblin)
        {
            goblin.Fireball(Damage);
        }
    }
}
