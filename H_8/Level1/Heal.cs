using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Level1
{
    internal class Heal : Spell
    {
        public int plushealth;
        
        public Heal(string name, string spell_info) : base(name, spell_info)
        {
            name = "Регенерация";
            spell_info = "Восстановление здоровья";
        }
        public override void Apply(Character goblin)
        {
            goblin.Heal(plushealth);
        }
    }
}
