using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Battle
    {
        private Character Mage;
        private Character Goblin;

        public Battle(Character mage, Character goblin)
        { 
            Mage = mage;
            Goblin = goblin;
        }
        public void BattleStarting()
        {
            Console.WriteLine("----Бой начался----");
            while (Mage.ISAlive && Goblin.ISAlive)
            {
                Mage.playerStep(Goblin);
                if (Goblin.ISAlive == false)
                {
                    break;
                }
                Console.WriteLine("----Обработка эффектов----");
                Mage.ProcessEffects();
                Goblin.ProcessEffects();
            }
            if (Goblin.ISAlive)
            {
                Console.WriteLine("Победил Гоблин");
            }
            else
            {
                Console.WriteLine("Победил Маг");
            }
        }
    }
}
