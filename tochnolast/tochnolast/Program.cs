using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochnolast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EquipmentManager equipment = new EquipmentManager();

            Weapon sword = new Weapon("Меч рыцаря", 15, 5, 0);
            Armor helmet = new Armor("Шлем дракона", ArmorType.Head, 8, 2, 1);
            Armor chestplate = new Armor("Одежда", ArmorType.Body, 20, 3, 0);
            Accessory ring = new Accessory("Кольцо силы", 4, 0, 10);
            Accessory amulet = new Accessory("Амулет мудрости", 0, 6, 20);

            equipment.EquipWeapon(sword);
            equipment.EquipArmor(helmet);
            equipment.EquipArmor(chestplate);
            equipment.EquipRing1(ring);
            equipment.EquipNecklace(amulet);

            Console.WriteLine();
            equipment.DisplayEquipment();

            Armor gloves = new Armor("Перчатки ловкости", ArmorType.Hands, 5, 0, 2);
            equipment.EquipArmor(gloves);


            Console.WriteLine();
            equipment.DisplayEquipment();

            equipment.UnequipWeapon();

            Console.WriteLine();
            equipment.DisplayEquipment();
        }
    }
}
