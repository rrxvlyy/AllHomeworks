using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2levelsred
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage("Маг", 100);
            Goblin goblin = new Goblin("Гоблин", 80);

            int turn = 1;

            while (mage.IsAlive && goblin.IsAlive)
            {
                Console.WriteLine($"\n--- ход {turn} ---");

                mage.MakeTurn(goblin);
                mage.ProcessEffects();
                goblin.ProcessEffects();

                if (!goblin.IsAlive) break;

                goblin.MakeTurn(mage);
                mage.ProcessEffects();
                goblin.ProcessEffects();

                turn++;
            }

            Console.WriteLine("\n--- бой завершен  ---");
            if (mage.IsAlive)
            {
                Console.WriteLine("победил маг");
            }
            else
            {
                Console.WriteLine("победил гоблин");
            }
        }
    }
}
