using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FirstDz_2
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
        static float FloatInput()
        {
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out float m))
                {
                    return m;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя игрока");
            string name = StringInput();
            Player2 player = new Player2(name);
            while (true)
            {
                Console.WriteLine("Если хотите ввести предмет, введите (да), иначе что-то другое");
                string check = Console.ReadLine();
                if (check == "да")
                {
                    Console.WriteLine("Введите название предмета");
                    string firstName = StringInput();
                    Console.WriteLine("Введите урон предмета");
                    int firstDamage = IntInput();
                    Console.WriteLine("Введите вес предмета");
                    float firstWeight = FloatInput();
                    Item item = new Item(firstName, firstDamage, firstWeight);
                    player.PickUpItem(item);
                }
                else
                {
                    player.ShowInventory();
                    break;
                }
            }
        }
    }
}
