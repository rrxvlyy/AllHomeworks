using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal abstract class Effect
    {
        private string name;
        private int duration;
        private int damage;
        private bool effectEnd => duration <= 0;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Duration
        {
            get
            {
                return duration;
            }
        }
        public int Damage
        {
            get
            {
                return damage;
            }
        }
        public bool EffectEnd
        {
            get
            {
                return effectEnd;
            }
        }
        public abstract void ApplyEffect(Character character);
        public abstract void EveryStep(Character character);
        public abstract void EffectEnding(Character character);
        public Effect(string name, int duration)
        {
            this.name = name;
            this.duration = duration;
        }
        public void DurationDecrease()
        {
            if (duration > 0)
            {
                duration--;
            }
        }
    }
}
