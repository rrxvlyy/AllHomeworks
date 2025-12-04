using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces
{
    internal class Food : Item, IUsable, IStackable
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

        public Food(string name, string description) : base("Еда", "Меняет энергию", 1)
        {

        }


        public void Use(Character user)
        {
            Console.Write("На сколько изменить энергию: ");
            int value = IntInput();
            user.AddEnergy(value);
            RemoveOne();
            if (Count == 0)
            {
                Inventory.RemoveItem(this);
            }
        }


        public void AddOne()
        {
            Count++;
        }


        public void RemoveOne()
        {
            Count--;
        }
    }
}