using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2levelsred
{
    public class Goblin : Character
    {
        public Goblin(string name, int health) : base(name, health) { }

        public override void MakeTurn(Character target)
        {
            System.Console.WriteLine($"{Name} атакует {target.Name}");
            target.TakeDamage(10);
        }
    }
}
