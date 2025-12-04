using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal abstract class Character
    {
        protected string name;
        protected int health_now;
        protected int health_max;
        protected bool isAlive;
        private List<Effect> active_effect;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Health_now
        {
            get
            {
                return health_now;
            }
        }
        public int Health_max
        {
            get
            {
                return health_max;
            }
        }
        public bool ISAlive
        {
            get
            {
                return isAlive;
            }
        }
        protected Character(string name, int health_now, int health_max)
        {
            this.name = name;
            this.health_now = health_now;
            this.health_max = health_max;
            active_effect = new List<Effect>();
        }
        public void ApplyDamage(int damage)
        {
            foreach(Effect effect in active_effect)
            {
                if (effect is Shielded shielded)
                {
                    damage = shielded.DamageReduction(damage);
                }
            }
            health_now -= damage;
            Console.WriteLine($"У {Name} осталось {health_now} здоровья");
        }
        public void AddEffect(Effect effect)
        {
            active_effect.Add(effect);
            effect.ApplyEffect(character);
        }
        public void ProcessEffects()
        {
            foreach (var effect in active_effect)
            {
                effect.ApplyEffect(character);
                effect.DurationDecrease();

                if (effect.EffectEnd)
                {
                    effect.EffectEnding(this);
                    active_effect.Remove(effect);
                }
            }
        }
        public abstract void playerStep(Character character);
    }
}
