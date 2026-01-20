using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Level1
{
    internal class Goblin : Character
    {
        public Goblin(string name) : base(name, 50) { }

        public override void TakeDamage(int damage)
        {
            int reducedDamage = Math.Max(0, damage - 1);
            if (reducedDamage < damage)
            {
                Console.WriteLine($"{Name} уменьшает урон на 1");
            }
            base.TakeDamage(reducedDamage);
        }
    }
}
