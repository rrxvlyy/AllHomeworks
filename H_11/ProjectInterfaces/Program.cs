using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces2
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
            int maxcountitems = 8;
            Console.WriteLine("Введите имя персонажа");
            string n = StringInput();
            Console.WriteLine("Введите текущее кол-во здоровья персонажа");
            int h_now = IntInput();
            Console.WriteLine("Введите макс. кол-во здоровья персонажа");
            int h_max = IntInput();
            Console.WriteLine("Введите текущее кол-во энергии персонажа");
            int e_now = IntInput();
            Console.WriteLine("Введите макс. кол-во энергии персонажа");
            int e_max = IntInput();
            Console.WriteLine("Введите количество золота персонажа");
            int g_count = IntInput();

            Character character = new Character(n, h_now, h_max, e_now, e_max, g_count);

            Item item1 = new HealthPotion("Зелье здоровья", "Меняет здоровье");
            Item item2 = new Food("Еда", "Меняет энергию");
            Item item3 = new Gem("Драгоценный камень", "Меняет кол-во золота");
            Item item4 = new OldBoot("Старый ботинок", "Выкидывается :/");
            Item item5 = new Weapon("Оружие", "Экипируется");
            Item item6 = new Armor("Броня", "Экипируется");
            Item item7 = new MagicRing("Магическое кольцо", "Экипируется и меняет кол-во золота");
            Item item8 = new Scroll("Свиток", "Меняет здоровье и кол-во золота");


            Inventory inventory = new Inventory(maxcountitems);
            inventory.Add(item1);
            inventory.Add(item2);
            inventory.Add(item3);
            inventory.Add(item4);
            inventory.Add(item5);
            inventory.Add(item6);
            inventory.Add(item7);
            inventory.Add(item8);


            while (true)
            {
                Console.WriteLine();
                character.ShowInfo();

                Console.WriteLine();
                inventory.ShowInventory();


                Console.WriteLine("\nВведите ИНДЕКС предмета");
                int index = IntInput();
                Item ITEM = Inventory.GetItem(index);
                Console.WriteLine("\nВы выбрали предмет: " + ITEM.Name);
                Console.WriteLine("\n--- ВЫБЕРИТЕ ДЕЙСТВИЕ ---");
                Console.WriteLine("1 - Использовать предмет");
                Console.WriteLine("2 — Экипировать предмет");
                Console.WriteLine("3 — Продать предмет");
                Console.WriteLine("4 — Выбросить предмет");
                Console.WriteLine("0 — Выход");
                Console.WriteLine();
                int a = IntInput();
                if (a == 0)
                {
                    break;
                }

                switch (a)
                {
                    case 1:
                        if (ITEM is IUsable usable)
                        {
                            usable.Use(character);
                        }
                        else
                        {
                            Console.WriteLine("--- Этот предмет нельзя использовать ---");
                        }
                        break;
                    case 2:
                        if (ITEM is IEquipable equipable)
                        {
                            equipable.Equip(character);
                        }
                        else
                        {
                            Console.WriteLine("--- Этот предмет нельзя экипировать ---");
                        }
                        break;
                    case 3:
                        if (ITEM is ISellable sellable)
                        {
                            sellable.Sell(character);
                        }
                        else
                        {
                            Console.WriteLine("--- Этот предмет нельзя продать ---");
                        }
                        break;
                    case 4:
                        if (ITEM is IDiscardable discardable)
                        {
                            discardable.Discard();
                        }
                        else
                        {
                            Console.WriteLine("--- Этот предмет нельзя выбросить ---");
                        }
                        break;
                    default:
                        Console.WriteLine("Выберите действие, введя цифру от 0 до 4");
                        break;
                }
            }
        }
    }
}
