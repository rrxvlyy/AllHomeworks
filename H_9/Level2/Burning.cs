using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Burning : Effect
    {
        private int damage;
        public Burning(int duration, int damage) : base("Сгорание", duration)
        {

        }
        public override void ApplyEffect(Character character)
        {
            Console.WriteLine($"Эффект Burning применен к персонажу {character}");
        }
        public override void EveryStep(Character character)
        {
            character.ApplyDamage(damage);
            Console.WriteLine($"{character} получил урон от эффекта Burning");
        }
        public override void EffectEnding(Character character)
        {
            Console.WriteLine($"Эффект Burning для персонажа {character} закончился");
        }
    }
}
