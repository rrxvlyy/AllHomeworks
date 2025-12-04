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
        public Goblin(string name, int health_now, int health_max) : base(name, health_now, health_max)
        {
        }
        public override void Fireball(int damage)
        {
            health_now -= (damage - 1);

            if (health_now <= 0)
            {
                is_Alive = false;
                Console.WriteLine("Гоблин умер");
            }
            Console.WriteLine($"Остаток здоровья: {health_now}");
        }

    }
}
