using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Mage : Character
    {
        static int IntInput()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    return n;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }
            }
        }
        private Random random;
        public Mage(string name, int health_now, int health_max) : base(name, health_now, health_max)
        {
            random = new Random();
        }
        private void Fireball(Character character)
        {
            int damage = 10;
            character.ApplyDamage(damage);
            if (random.NextDouble() < 0.5)
            {
                character.AddEffect(new Burning(2, 5));
            }
        }
        private void Shield(Character character)
        {
            character.AddEffect(new Shielded(2));
        }
        public override void playerStep(Character character)
        {
            if (character.ISAlive == false)
            {
                return;
            }
            Console.WriteLine("----Ход мага----");
            Console.WriteLine("Выбор заклинания:");
            int n = IntInput();
            switch (n)
            {
                case 1:
                    Fireball(character);
                    break;
                case 2:
                    Shield(character);
                    break;
            }
        }
    }
}
