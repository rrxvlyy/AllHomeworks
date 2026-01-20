using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2levelsred
{
    public class Burning : Effect
    {
        private int damagePerTurn;

        public Burning(int duration, int damagePerTurn) : base("Burning", duration)
        {
            this.damagePerTurn = damagePerTurn;
        }

        public override void OnTurn(Character target)
        {
            Console.WriteLine($"{target.Name} горит и получает {damagePerTurn} урона");
            target.TakeDamage(damagePerTurn);
        }
    }
}
