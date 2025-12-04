using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces
{

    internal class HealthPotion : Item, IUsable, IStackable
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
        public HealthPotion(string name, string description) : base("Зелье здоровья", "Меняет здоровье", 1)
        {

        }


        public void AddOne()
        {
            Count++;
        }


        public void RemoveOne()
        {
            Count--;
        }


        public void Use(Character user)
        {
            Console.Write("На сколько изменить здоровье: ");
            int value = IntInput();
            user.AddHealth(value);
            RemoveOne();
            if (Count == 0)
            {
                Inventory.RemoveItem(this);
            }
        }
    }
}
