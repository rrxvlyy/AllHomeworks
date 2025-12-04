using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Goblin : Character
    {
        private Random random;
        public Goblin(string name, int health_now, int health_max) : base(name, health_now, health_max)
        {
            random = new Random();
        }
        public override void playerStep(Character character)
        {
            if (character.ISAlive == false)
            {
                return;
            }
            Console.WriteLine("----Ход гоблина----");
            int damage = random.Next(5, 10);
            ApplyDamage(damage);
        }
    }
}
