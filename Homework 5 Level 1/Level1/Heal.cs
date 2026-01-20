using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Level1
{
    internal class Heal : Spell
    {
        private int healAmount;

        public Heal() : base("Лечение", "Восстанавливает 10-20 здоровья")
        {
            Random rand = new Random();
            healAmount = rand.Next(10, 21);
        }

        public override void Cast(Character caster, Character target)
        {
            Console.WriteLine($"{caster.Name} применяет лечение на {target.Name}");
            target.Heal(healAmount);
        }
    }
}
