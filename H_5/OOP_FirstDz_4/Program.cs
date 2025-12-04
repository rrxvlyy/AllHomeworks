using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOP_FirstDz_4
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
            Console.WriteLine("Введите максимальный вес инвентаря");
            float ww = FloatInput();
            Console.WriteLine("Введите размер массива");
            int rr = IntInput();
            PlayerInventory inventory = new PlayerInventory(ww, rr);
            while (true)

            {
                Console.WriteLine("Если хотите ввести предмет, введите (да), иначе что-то другое");
                string check = Console.ReadLine();
                if (check == "да")
                {
                    Console.WriteLine("Введите название предмета");
                    string n = StringInput();
                    Console.WriteLine("Введите вес предмета");
                    float w = FloatInput();
                    Item item = new Item(n, w);
                    inventory.AddItem(item);
                }
                else
                {
                    Console.WriteLine($"Вес инвентаря: {inventory.GetTotalWeight()}");
                    break;

                }
            }
            

        }
    }
}
