using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2levelsred
{
    public class Shielded : Effect
    {
        private int damageReduction;

        public Shielded(int duration, int damageReduction) : base("Shielded", duration)
        {
            this.damageReduction = damageReduction;
        }

        public int ReduceDamage(int damage)
        {
            return Math.Max(0, damage - damageReduction);
        }

        public override void OnTurn(Character target)
        {
            Console.WriteLine($"{target.Name} защищён щитом");
        }

        public override void OnExpire(Character target)
        {
            Console.WriteLine($"Щит на {target.Name} пропал");
        }
    }
}
