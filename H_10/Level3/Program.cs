using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level3
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
            Console.WriteLine("Введите имя 1 игрока");
            string firstname = StringInput();
            Console.WriteLine("Введите имя 2 игрока");
            string secondname = StringInput();

            Player FirstPlayer = new Player(firstname, 100);
            Player SecondPlayer = new Player(secondname, 100);

            Spell FireBall = new Spell("Огненный шар", 3);
            Spell Heal = new Spell("Защита", 2);

            FirstPlayer.AddSpell(FireBall);
            FirstPlayer.AddSpell(Heal);
            SecondPlayer.AddSpell(FireBall);
            SecondPlayer.AddSpell(Heal);

            Journal journal = new Journal();

            for (int round = 1;  round <= 10; round++)
            {
                Console.WriteLine("Раунд" + round);
                FirstPlayer.UpdateAllCooldowns();
                SecondPlayer.UpdateAllCooldowns();

                Console.WriteLine("Выберите заклинание Мага");
                Console.WriteLine("1 - FireBall");
                Console.WriteLine("2 - Heal");
                int n = IntInput();
                switch (n)
                {
                    case 1:
                        FirstPlayer.TakeDamage();
                        string actionFireBall_1player = FirstPlayer.SpellStatus(FireBall);
                        journal.AddAction(actionFireBall_1player);
                        break;
                    case 2:
                        FirstPlayer.RecoveryHealth();
                        string actionHeal_1player = FirstPlayer.SpellStatus(Heal);
                        journal.AddAction(actionHeal_1player);
                        break;
                    default:
                        Console.WriteLine("Введите число - 1 или 2");
                        break;
                }
                Console.WriteLine("Выберите заклинание Гоблина");
                Console.WriteLine("1 - FireBall");
                Console.WriteLine("2 - Heal");
                int m = IntInput();
                switch (m)
                {
                    case 1:
                        SecondPlayer.TakeDamage();
                        string actionFireBall_2player = SecondPlayer.SpellStatus(FireBall);
                        journal.AddAction(actionFireBall_2player);
                        break;
                    case 2:
                        SecondPlayer.RecoveryHealth();
                        string actionHeal_2player = SecondPlayer.SpellStatus(Heal);
                        journal.AddAction(actionHeal_2player);
                        break;
                    default:
                        Console.WriteLine("Введите число - 1 или 2");
                        break;
                }
                journal.AddAction("Оставшееся здоровье 1 игрока: " + FirstPlayer.Health);
                journal.AddAction("Оставшееся здоровье 2 игрока: " + SecondPlayer.Health);
                journal.JournalPrint();
                
            }
        }
    }
}
