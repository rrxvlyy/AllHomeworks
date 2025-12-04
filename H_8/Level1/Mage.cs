using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class Mage : Character
    {
        public Mage(string name, int health_now, int health_max) : base(name, health_now, health_max)
        {
        }
        string[] allspells = new string[3];
        public void ShowSpells()
        {
            allspells[0] = "1. Fireball - наносит урон"; 
            allspells[1] = "2 Heal - восстанавливает здоровье";
            allspells[2] = "3. Shield - дает временную защиту";
            for (int i = 0; i < allspells.Length; i++)
            {
                Console.WriteLine(allspells[i]);
            }
        }
    }
}
