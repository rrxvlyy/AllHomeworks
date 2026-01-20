using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2levelsred
{
    public abstract class Character
    {
        public string Name { get; }
        public int Health { get; private set; }
        public bool IsAlive => Health > 0;

        private List<Effect> activeEffects = new List<Effect>();

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void AddEffect(Effect effect)
        {
            effect.OnApply(this);
            activeEffects.Add(effect);
        }
        public void TakeDamage(int damage)
        {
            foreach (var effect in activeEffects.OfType<Shielded>())
            {
                damage = effect.ReduceDamage(damage);
            }

            Health -= damage;
            Console.WriteLine($"{Name} получает {damage} урона. Осталось HP: {Health}");
        }

        public void ProcessEffects()
        {
            Console.WriteLine($"\n-- Обработка эффектов для {Name} --");

            for (int i = activeEffects.Count - 1; i >= 0; i--)
            {
                bool expired = activeEffects[i].Tick(this);
                if (expired == true)
                    activeEffects.RemoveAt(i);
            }
        }
        public abstract void MakeTurn(Character target);
    }
}
