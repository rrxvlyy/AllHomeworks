using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochnolast
{
    public class EquipmentManager
    {
        private Weapon weapon;
        private Armor headArmor;
        private Armor bodyArmor;
        private Armor handsArmor;
        private Armor legsArmor;
        private Armor bootsArmor;
        private Accessory ring1;
        private Accessory ring2;
        private Accessory necklace;


        public bool EquipWeapon(Weapon newWeapon)
        {
            if (newWeapon == null)
            {
                Console.WriteLine("Невозможно экипировать несуществующее оружие");
                return false;
            }

            Weapon oldWeapon = weapon;
            weapon = newWeapon;
            Console.WriteLine("Экипировано оружие: " + newWeapon.Name);

            if (oldWeapon != null)
            {
                Console.WriteLine("Снято оружие: " + oldWeapon.Name);
            }

            return true;
        }


        public bool EquipArmor(Armor newArmor)
        {
            if (newArmor == null)
            {
                Console.WriteLine("Невозможно экипировать несуществующую броню");
                return false;
            }

            Armor oldArmor = null;


            switch (newArmor.Type)
            {
                case ArmorType.Head:
                    oldArmor = headArmor;
                    headArmor = newArmor;
                    break;
                case ArmorType.Body:
                    oldArmor = bodyArmor;
                    bodyArmor = newArmor;
                    break;
                case ArmorType.Hands:
                    oldArmor = handsArmor;
                    handsArmor = newArmor;
                    break;
                case ArmorType.Legs:
                    oldArmor = legsArmor;
                    legsArmor = newArmor;
                    break;
                case ArmorType.Boots:
                    oldArmor = bootsArmor;
                    bootsArmor = newArmor;
                    break;
                default:
                    Console.WriteLine("Неизвестный тип брони");
                    return false;
            }
            Console.WriteLine("Экипирована броня " + newArmor.Type + ": " + newArmor.Name);

            if (oldArmor != null)
            {
                Console.WriteLine("Снята броня: " + oldArmor.Name);
            }

            return true;
        }
        public bool EquipRing1(Accessory ring)
        {
            if (ring == null)
            {
                Console.WriteLine("Невозможно экипировать несуществующее кольцо");
                return false;
            }

            Accessory oldRing = ring1;
            ring1 = ring;
            Console.WriteLine("Экипировано кольцо в слот 1: " + ring.Name);

            if (oldRing != null)
            {
                Console.WriteLine("Снято кольцо: " + oldRing.Name);
            }

            return true;
        }


        public bool EquipRing2(Accessory ring)
        {
            if (ring == null)
            {
                Console.WriteLine("Невозможно экипировать несуществующее кольцо");
                return false;
            }

            Accessory oldRing = ring2;
            ring2 = ring;
            Console.WriteLine("Экипировано кольцо в слот 2: " + ring.Name);

            if (oldRing != null)
            {
                Console.WriteLine("Снято кольцо: " + oldRing.Name);
            }

            return true;
        }


        public bool EquipNecklace(Accessory newNecklace)
        {
            if (newNecklace == null)
            {
                Console.WriteLine("Невозможно экипировать несуществующее ожерелье");
                return false;
            }

            Accessory oldNecklace = necklace;
            necklace = newNecklace;
            Console.WriteLine("Экипировано ожерелье: " + newNecklace.Name);

            if (oldNecklace != null)
            {
                Console.WriteLine("Снято ожерелье: " + oldNecklace.Name);
            }

            return true;
        }


        public Weapon UnequipWeapon()
        {
            Weapon oldWeapon = weapon;
            weapon = null;

            if (oldWeapon != null)
            {
                Console.WriteLine("Снято оружие: " + oldWeapon.Name);
            }

            return oldWeapon;
        }


        public Armor UnequipArmor(ArmorType type)
        {
            Armor oldArmor = null;

            switch (type)
            {
                case ArmorType.Head:
                    oldArmor = headArmor;
                    headArmor = null;
                    break;
                case ArmorType.Body:
                    oldArmor = bodyArmor;
                    bodyArmor = null;
                    break;
                case ArmorType.Hands:
                    oldArmor = handsArmor;
                    handsArmor = null;
                    break;
                case ArmorType.Legs:
                    oldArmor = legsArmor;
                    legsArmor = null;
                    break;
                case ArmorType.Boots:
                    oldArmor = bootsArmor;
                    bootsArmor = null;
                    break;
            }
            if (oldArmor != null)
            {
                Console.WriteLine("Снята броня: " + oldArmor.Name);
            }

            return oldArmor;
        }
        public EquipmentStats GetTotalStats()
        {
            EquipmentStats stats = new EquipmentStats();

            if (weapon != null)
            {
                stats.Damage += weapon.Damage;
                stats.Strength += weapon.StrengthBonus;
                stats.Intelligence += weapon.IntelligenceBonus;
            }

            AddArmorStats(headArmor, ref stats);
            AddArmorStats(bodyArmor, ref stats);
            AddArmorStats(handsArmor, ref stats);
            AddArmorStats(legsArmor, ref stats);
            AddArmorStats(bootsArmor, ref stats);

            AddAccessoryStats(ring1, ref stats);
            AddAccessoryStats(ring2, ref stats);
            AddAccessoryStats(necklace, ref stats);

            return stats;
        }

        private void AddArmorStats(Armor armor, ref EquipmentStats stats)
        {
            if (armor != null)
            {
                stats.Defense += armor.Defense;
                stats.Strength += armor.StrengthBonus;
                stats.Intelligence += armor.IntelligenceBonus;
            }
        }


        private void AddAccessoryStats(Accessory accessory, ref EquipmentStats stats)
        {
            if (accessory != null)
            {
                stats.Strength += accessory.StrengthBonus;
                stats.Intelligence += accessory.IntelligenceBonus;
                stats.Health += accessory.HealthBonus;
            }
        }


        public void DisplayEquipment()
        {
            Console.WriteLine("--- экипировка ---");

            Console.WriteLine("Оружие: " + (weapon != null ? weapon.Name : "Пусто"));
            Console.WriteLine("Голова: " + (headArmor != null ? headArmor.Name : "Пусто"));
            Console.WriteLine("Тело: " + (bodyArmor != null ? bodyArmor.Name : "Пусто"));
            Console.WriteLine("Руки: " + (handsArmor != null ? handsArmor.Name : "Пусто"));
            Console.WriteLine("Ноги: " + (legsArmor != null ? legsArmor.Name : "Пусто"));
            Console.WriteLine("Обувь: " + (bootsArmor != null ? bootsArmor.Name : "Пусто"));
            Console.WriteLine("Кольцо 1: " + (ring1 != null ? ring1.Name : "Пусто"));
            Console.WriteLine("Кольцо 2: " + (ring2 != null ? ring2.Name : "Пусто"));
            Console.WriteLine("Ожерелье: " + (necklace != null ? necklace.Name : "Пусто"));

            EquipmentStats totalStats = GetTotalStats();
            Console.WriteLine("\n--- общие характ-ки от экипировки ---");
            Console.WriteLine("Урон: " + totalStats.Damage);
            Console.WriteLine("Защита: " + totalStats.Defense);
            Console.WriteLine("Сила: " + totalStats.Strength);
            Console.WriteLine("Интеллект: " + totalStats.Intelligence);
            Console.WriteLine("Здоровье: " + totalStats.Health);
        }


        public struct EquipmentStats
        {
            public int Damage;
            public int Defense;
            public int Strength;
            public int Intelligence;
            public int Health;
        }
    }
}
