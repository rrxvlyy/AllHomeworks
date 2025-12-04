using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces2
{
    internal class Food : Item, IUsable
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
        private int value;
        public Food(string name, string description) : base("Еда", "Меняет энергию")
        {

        }


        public void Use(Character user)
        {
            Console.Write("На сколько изменить энергию: ");
            int value = IntInput();
            user.AddEnergy(value);
        }
    }
}