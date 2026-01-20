using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2levelsred
{
    public class Mage : Character
    {
        private Spell fireball = new Fireball();
        private Spell shield = new ShieldSpell();

        public Mage(string name, int health) : base(name, health) { }

        public override void MakeTurn(Character target)
        {
            fireball.Cast(this, target);
            shield.Cast(this, this);
        }
    }
}
