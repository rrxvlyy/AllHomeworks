using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces2
{
    internal class Scroll: Item, IUsable, ISellable
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
        public int Price { get; } = 20;
        private int value;

        public Scroll(string name, string description) : base("Свиток", "Меняет здоровье и кол-во золота")
        {

        }


        public void Use(Character user)
        {
            Console.Write("На сколько изменить здоровье: ");
            int value = IntInput();
            user.AddHealth(value);
        }


        public void Sell(Character user)
        {
            user.AddGold(Price);
        }
    }
}
