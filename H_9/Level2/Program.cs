using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage("Маг", 100, 100);
            Goblin goblin = new Goblin("Гоблин", 100, 100);
            Battle battle = new Battle(mage, goblin);
            battle.BattleStarting();
        }
    }
}
