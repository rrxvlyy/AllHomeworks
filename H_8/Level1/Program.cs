using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class Program
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
        static string StringInput()
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (s.Length > 0)
                {
                    return s;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }
            }
        }
        static void Main(string[] args)
        {
            Mage mage = new Mage("Маг");
            Goblin goblin = new Goblin("Гоблин");

            Spell fireball = new Fireball();
            Spell heal = new Heal();
            Spell shield = new Shield();

            mage.AddSpell(fireball);
            mage.AddSpell(heal);
            mage.AddSpell(shield);

            mage.Show_Info();
            goblin.Show_Info();

            Console.WriteLine("--- начало битвы ---");

            mage.ShowSpellBook();

            mage.CastSpell(1, goblin);

            mage.CastSpell(2, goblin);

            mage.CastSpell(3, goblin);

            mage.CastSpell(1, goblin);

            Console.WriteLine("--- итоги битвы ---");
            mage.Show_Info();
            goblin.Show_Info();
        }
    }
}
