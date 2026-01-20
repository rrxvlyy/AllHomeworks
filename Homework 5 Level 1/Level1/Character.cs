using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal abstract class Character
    {
        public string name;
        public int health_now;
        public int health_max;
        public bool is_Alive;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Health_now
        {
            get
            {
                return health_now;
            }
        }
        public int Health_max
        {
            get
            {
                return health_max;
            }
        }
        public bool Is_Alive
        {
            get
            {
                return is_Alive;
            }
        }


        public Character(string name, int health_max)
        {
            this.name = name;
            this.health_now = health_max;
            this.health_max = health_max;
            this.is_Alive = true;
        }


        public virtual void TakeDamage(int damage)
        {
            if (is_Alive == false)
            {
                return;
            }

            health_now -= damage;
            Console.WriteLine($"{name} получает {damage} урона");

            if (health_now < 0)
            {
                health_now = 0;
                is_Alive = false;
                Console.WriteLine($"{name} умер");
            }
            else
            {
                Console.WriteLine($"У {name} осталось {health_now}/{health_max} здоровья");
            }
        }


        public void Heal(int healAmount)
        {
            if (is_Alive == false)
            {
                return;
            }

            health_now += healAmount;
            if (health_now > health_max)
            {
                health_now = health_max;
            }

            Console.WriteLine($"{name} восстанавливает {healAmount} здоровья. Здоровье {health_now}/{health_max}");
        }


        public virtual void Show_Info()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Текущее здоровье: " + health_now);
            Console.WriteLine("Макс.здоровье: " + health_max);
        }
    }
}
