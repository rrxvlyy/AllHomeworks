using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3levelsred
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character("Герой", 100);
            Character monster = new Character("Монстр", 120);

            hero.AddSpell(new Spell("Огненный шар", 25, 3));
            hero.AddSpell(new Spell("Лечение", -20, 4));
            monster.AddSpell(new Spell("Удар когтями", 18, 2));

            Battle battle = new Battle(hero, monster);
            battle.Start();
        }
    }
}
