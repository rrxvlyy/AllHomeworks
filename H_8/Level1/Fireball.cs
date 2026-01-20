using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class Fireball : Spell
    {
        private int damage;

        public Fireball() : base("Огненный шар", "Наносит 15-25 урона огнём")
        {
            Random rand = new Random();
            damage = rand.Next(15, 26);
        }

        public override void Cast(Character caster, Character target)
        {
            Console.WriteLine($"{caster.Name} бросает огненный шар в {target.Name}");
            target.TakeDamage(damage);
        }
    }
}
