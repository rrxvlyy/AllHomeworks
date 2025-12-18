using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
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
            Player player = new Player(100);
            bool isActive = false;
            Door door1 = new Door("Дверь1", isActive);
            Door door2 = new Door("Дверь2", isActive);
            Checkpoint checkpoint1 = new Checkpoint("Чекпоинт1");
            Checkpoint checkpoint2 = new Checkpoint("Чекпоинт2");
            Trap trap1 = new Trap("Ловушка1", 10);
            Trap trap2 = new Trap("Ловушка2", 10);


            Console.WriteLine("- Информация об объектах -");
            Console.WriteLine(door1.Info());
            Console.WriteLine(door2.Info());
            Console.WriteLine(checkpoint1.Info());
            Console.WriteLine(checkpoint2.Info());
            Console.WriteLine(trap1.Info());
            Console.WriteLine(trap2.Info());


            Console.WriteLine("- Взаимодействие -");
            Console.WriteLine(door1.Interact(player));
            isActive = true;
            Console.WriteLine(door1.Interact(player));


            Console.WriteLine("Ловушки")
            Console.WriteLine(trap1.Interact());
            Console.WriteLine(trap2.Interact());
        }
    }
}
