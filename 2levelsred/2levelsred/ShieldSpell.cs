using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _2levelsred
{
    internal class ShieldSpell : Spell
    {
        public ShieldSpell() : base("Shield") { }

        public override void Cast(Character caster, Character target)
        {
            Console.WriteLine($"{caster.Name} накладывает Shield щит на {target.Name}");
            target.AddEffect(new Shielded(3, 5));
        }
    }
}
