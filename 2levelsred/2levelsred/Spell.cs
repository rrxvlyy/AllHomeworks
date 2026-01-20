using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _2levelsred
{
    public abstract class Spell
    {
        public string Name { get; }

        protected Spell(string name)
        {
            Name = name;
        }

        public abstract void Cast(Character caster, Character target);
    }
}
