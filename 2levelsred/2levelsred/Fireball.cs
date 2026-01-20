using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _2levelsred
{
    public class Fireball : Spell
    {
        private Random rng = new Random();

        public Fireball() : base("Fireball") { }

        public override void Cast(Character caster, Character target)
        {
            Console.WriteLine($"{caster.Name} использует Fireball на {target.Name}");
            target.TakeDamage(15);

            if (rng.Next(100) < 40)
            {
                target.AddEffect(new Burning(3, 5));
            }
        }
    }
}
