using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces2
{

    internal class HealthPotion : Item, IUsable
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


        public HealthPotion(string name, string description) : base("Зелье здоровья", "Меняет здоровье")
        {

        }


        public void Use(Character user)
        {
            Console.Write("На сколько изменить здоровье: ");
            int value = IntInput();
            user.AddHealth(value);
        }
    }
}
