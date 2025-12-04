using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal abstract class Spell
    {
        protected string name;
        protected string spell_info;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Spell_info
        {
            get
            {
                return spell_info;
            }
        }
        public Spell(string name, string spell_info)
        {
            this.name = name;
            this.spell_info = spell_info;
        }
        public abstract void Apply(Character goblin);
        public void PrintInfoSpell(Spell spell)
        {
            Console.WriteLine(spell.Name);
            Console.WriteLine(spell.Spell_info);
        }
    }
}
