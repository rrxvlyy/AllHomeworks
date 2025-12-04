using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FirstDz_3
{
    internal class Player
    {
        private string name;

        public Player(string name)
        {
            this.name = name;
        }
        PlayerInventory inventory = new PlayerInventory();
        public string Name
        {
            get
            {
                return name;
            }
        }
        public void PickUpItem(Item item)
        {
            inventory.AddItem(item);
            Console.WriteLine(item.Name + " добавлен в инвентарь");
        }
        public void ShowInventoryWeight()
        {
            Console.WriteLine("Вес предметов инвентаря");
            inventory.WhatsOnInventory();
        }
        public void GetInventoryValue(Item item)
        {
            Console.WriteLine("Текущая стоимость инвентаря");
            inventory.GetTotalPrice(item);
        }
    }
}
