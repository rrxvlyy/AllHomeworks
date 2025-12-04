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
        protected string name;
        protected int health_now;
        protected int health_max;
        protected bool is_Alive = true;
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
        public Character(string name, int health_now, int health_max)
        {
            this.name = name;
            this.health_now = health_now;
            this.health_max = health_max;
        }
        public virtual void Fireball(int damage)
        {
            health_now -= damage;
            if (health_now <= 0)
            {
                is_Alive = false;
                Console.WriteLine("Гоблин умер");
            }
            Console.WriteLine($"Остаток здоровья: {health_now}");
        }
        public void Heal(int plushealth)
        {
            if (plushealth <= 0)
            {
                return;
            }
            health_now += plushealth;
            if (health_now > health_max)
            {
                health_now = health_max;
            }
            Console.WriteLine($"Остаток здоровья: {health_now}");
        }
        public void Shield()
        {
            if (Protect.protect == false)
            {
                Console.WriteLine($"Временная защита активирована");
                Protect.protect = true;
            }
            else
            {
                Console.WriteLine($"Временная защита деактивирована");
                Protect.protect = false;
            }
        }
        public virtual void Show_Info()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Текущее здоровье: " + health_now);
            Console.WriteLine("Макс.здоровье: " + health_max);
        }
    }
}
