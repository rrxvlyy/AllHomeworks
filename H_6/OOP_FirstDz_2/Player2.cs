using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FirstDz_2
{
    internal class Player2
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        PlayerInventory inventory = new PlayerInventory();
        public Player2(string name)
        {
            this.name = name;
            inventory = new PlayerInventory();
        }
        public void PickUpItem(Item item)
        {
            inventory.AddItem(item);
        }
        public void ShowInventory()
        {
            Console.WriteLine("Предметы инвентаря игрока " + Name);
            inventory.WhatsOnInventory();

        }
    }
}
