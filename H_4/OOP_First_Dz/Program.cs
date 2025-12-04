using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_First_Dz
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
            Console.WriteLine("Введите имя 1 предмета");
            string firstName = StringInput();
            Console.WriteLine("Введите цену 1 предмета");
            int firstPrice = IntInput();
            Console.WriteLine("Введите вес 1 предмета");
            float firstWeight = FloatInput();
            Console.WriteLine("Введите имя 2 предмета");
            string secondName = StringInput();
            Console.WriteLine("Введите цену 2 предмета");
            int secondPrice = IntInput();
            Console.WriteLine("Введите вес 2 предмета");
            float secondWeight = FloatInput();
            Item firstItem = new Item(firstName, firstPrice, firstWeight);
            Item secondItem = new Item(secondName, secondPrice, secondWeight);
            Item[] array = { firstItem, secondItem };
            array[0].DisplayInfo();
            array[1].DisplayInfo();
        }
    }
}
