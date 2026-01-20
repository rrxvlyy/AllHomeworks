using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2levelsred
{
    public abstract class Effect
    {
        public string Name { get; }
        public int Duration { get; protected set; }

        protected Effect(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public virtual void OnApply(Character target)
        {
            Console.WriteLine($"{target.Name} получает эффект {Name} на {Duration} ходов");
        }

        public abstract void OnTurn(Character target);

        public virtual void OnExpire(Character target)
        {
            Console.WriteLine($"Эффект {Name} на {target.Name} закончился");
        }

        public bool Tick(Character target)
        {
            OnTurn(target);
            Duration--;
            if (Duration <= 0)
            {
                OnExpire(target);
                return true;
            }
            return false;
        }
    }
}
