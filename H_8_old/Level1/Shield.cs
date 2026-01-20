using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class Shield : Spell
    {
        public Shield(string name, string spell_info) : base(name, spell_info)
        {
            name = "Щит";
            spell_info = "Дает временную защиту";
        }
        public override void Apply(Character goblin)
        {
            goblin.Shield();
        }
    }
}
