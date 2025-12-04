using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces
{
    internal class Character
    {
        private string name;
        private int health_now;
        private int health_max;
        private int energy_now;
        private int energy_max;
        private int gold_count;
        private Weapon equipped_weapon;
        private Armor equipped_armor;
        private MagicRing equipped_ring;

        public string Name { get { return name; } }
        public int Health_now { get { return health_now; } }
        public int Health_max { get { return health_max; } }
        public int Energy_now { get { return energy_now; } }
        public int Energy_max { get { return energy_max; } }
        public int Gold_count { get { return gold_count; } }
        public Weapon Equipped_weapon { get { return equipped_weapon; } }
        public Armor Equipped_armor { get { return equipped_armor; } }
        public MagicRing Equipped_ring { get { return equipped_ring; } }


        public Character(string name, int health_now, int health_max, int energy_now, int energy_max, int gold_count)
        {
            this.name = name;
            this.health_now = health_now;
            this.health_max = health_max;
            this.energy_now = energy_now;
            this.energy_max = energy_max;
            this.gold_count = gold_count;
        }


        public void AddHealth(int value)
        {
            if (value >= 0)
            {
                health_now += value;
            }
            else if (value < 0)
            {
                health_now += value;
            }

            if (health_now < 0)
            {
                health_now = 0;
            }
            else if (health_now > health_max)
            {
                health_now = health_max;
            }
        }


        public void AddEnergy(int value)
        {

            if (value >= 0)
            {
                energy_now += value;
            }
            else if (value < 0)
            {
                energy_now += value;
            }

            if (energy_now < 0)
            {
                energy_now = 0;
            }
            else if (energy_now > energy_max)
            {
                energy_now = energy_max;
            }
        }


        public void AddGold(int value)
        {
            if (value >= 0)
            {
                gold_count += value;
            }
            else
            {
                gold_count -= value;
            }

            if (gold_count < 0)
            {
                gold_count = 0;
            }
        }


        public void EquipWeapon(Weapon weapon)
        {
            Console.WriteLine("Оружие экипировано");
        }


        public void EquipArmor(Armor armor)
        {
            Console.WriteLine("Броня экипирована");
        }


        public void EquipRing(MagicRing ring)
        {
            Console.WriteLine("Кольцо экипировано");
        }


        public void UnequipWeapon(Weapon weapon)
        {
            Console.WriteLine("Оружие снято");
        }


        public void UnequipArmor(Armor armor)
        {
            Console.WriteLine("Броня снята");
        }


        public void UnequipRing(MagicRing ring)
        {
            Console.WriteLine("Кольцо снято");
        }


        public void ShowInfo()
        {
            Console.WriteLine("--- ИНФОРМАЦИЯ О ПЕРСОНАЖЕ ---");
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Здоровье сейчас: " + Health_now);
            Console.WriteLine("Макс.здоровье: " + Health_max);
            Console.WriteLine("Энергия сейчас: " + Energy_now);
            Console.WriteLine("Макс.энергия: " + Energy_max);
            Console.WriteLine("Кол-во золота: " + Gold_count);
        }
    }
}
