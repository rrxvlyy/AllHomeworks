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
            Console.WriteLine("Введите название мага");
            string character_name1 = StringInput();
            Console.WriteLine("Введите макс.здоровье мага");
            int character_maxhealth1 = IntInput();
            int character_nowhealth1 = character_maxhealth1;
            Mage Mage = new Mage(character_name1, character_nowhealth1, character_maxhealth1);
            Console.WriteLine("Введите название гоблина");
            string character_name2 = StringInput();
            Console.WriteLine("Введите макс.здоровье гоблина");
            int character_maxhealth2 = IntInput();
            int character_nowhealth2 = character_maxhealth2;
            Goblin Goblin = new Goblin(character_name2, character_nowhealth2, character_maxhealth2);
            Console.WriteLine();

            Console.WriteLine("а. Показать информацию о персонажах");
            Console.WriteLine("б. Показать заклинания");

            Console.WriteLine();
            while (true)
            {
                Console.WriteLine();
                Console.Write("Введите букву от а до б, для выхода напишите (выход): ");
                string s = StringInput();
                if (s.Equals("выход", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                Console.WriteLine();
                switch (s)
                {
                    case "а":
                        Mage.Show_Info();
                        Goblin.Show_Info();
                        break;
                    case "б":
                        Mage.ShowSpells();
                        Console.WriteLine("Если хотите применить заклинание, введите цифру от 1 до 3, если нет, напишите (нет)");
                        string n = StringInput();
                        if (n.Equals("нет", StringComparison.OrdinalIgnoreCase))
                        {
                            break;
                        }
                        if (n == "1")
                        {
                            Console.WriteLine("Введите урон");
                            int damage = IntInput();
                            if (Protect.protect == false)
                            {
                                Goblin.Fireball(damage);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Активирована защита, невозможно нанести урон");
                                break;
                            }
                        }
                        else if (n == "2")
                        {
                            Console.WriteLine("На сколько восстановить здоровье?");
                            int plushealth = IntInput();
                            Goblin.Heal(plushealth);
                            break;
                        }
                        else if (n == "3")
                        {
                            Goblin.Shield();
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Неверный ввод! Пожалуйста, выберите букву от а до б.");
                        break;
                }
            } 
        }
    }
}
