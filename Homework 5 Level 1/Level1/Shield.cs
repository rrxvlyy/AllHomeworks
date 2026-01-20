using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class Shield : Spell
    {
        private int shieldAmount;

        public Shield() : base("Щит", "Даёт временную защиту на 5-10 урона")
        {
            Random rand = new Random();
            shieldAmount = rand.Next(5, 11);
        }

        public override void Cast(Character caster, Character target)
        {
            Console.WriteLine($"{caster.Name} накладывает щит на {target.Name}");
            Console.WriteLine($"{target.Name} получает временную защиту на {shieldAmount} урона");
            target.Heal(shieldAmount / 2);
        }
    }
}
