using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FirstDz_3
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
            Player player = new Player(name);
            while (true)
            {
                Console.WriteLine("Если хотите ввести предмет, введите (да), иначе что-то другое");
                string check = Console.ReadLine();
                if (check == "да")
                {
                    Console.WriteLine("Введите название предмета");
                    string firstName = StringInput();
                    Console.WriteLine("Введите цену предмета");
                    int firstPrice = IntInput();
                    Console.WriteLine("Введите вес предмета");
                    float firstWeight = FloatInput();
                    Item item = new Item(firstName, firstPrice, firstWeight);
                    player.PickUpItem(item);
                    player.GetInventoryValue(item);
                }
                else
                {
                    player.ShowInventoryWeight();
                    break;
                }
            }
        }
    }
}
