using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal abstract class Spell
    {
        public string Name { get; }
        public string Description { get; }

        protected Spell(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public abstract void Cast(Character caster, Character target);

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}: {Description}");
        }
    }
}
