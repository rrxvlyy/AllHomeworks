using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Shielded : Effect
    {
        private int damage;
        public Shielded(int duration) : base("Защита", duration)
        {
        }
        public override void ApplyEffect(Character character)
        {
            Console.WriteLine($"Эффект Shielded применен к персонажу {character}");
        }
        public override void EveryStep(Character character)
        {
            Console.WriteLine($"{character} получает уменьшенный урон из-за эффекта Shielded");
        }
        public override void EffectEnding(Character character)
        {
            Console.WriteLine($"Эффект Shielded для персонажа {character} закончился");
        }
        public int DamageReduction(int damage)
        {
            return (damage - 1);
        }
    }
}
