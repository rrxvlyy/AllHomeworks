using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3levelsred
{
    internal class Character
    {
        public string Name { get; }
        public int MaxHealth { get; }
        public int Health { get; private set; }

        public List<Spell> Spells { get; private set; }
        public List<Effect> ActiveEffects { get; private set; }

        public Character(string name, int maxHealth)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            Spells = new List<Spell>();
            ActiveEffects = new List<Effect>();
        }

        public void AddSpell(Spell spell)
        {
            Spells.Add(spell);
        }

        public void TakeDamage(int amount)
        {
            Health = Math.Max(0, Health - amount);
        }

        public void Heal(int amount)
        {
            Health = Math.Min(MaxHealth, Health + amount);
        }
        public bool IsAlive() => Health > 0;

        public void UpdateCooldowns()
        {
            foreach (var spell in Spells)
                spell.ReduceCooldown();
        }

        public void UpdateEffects()
        {
            foreach (var effect in ActiveEffects.ToList())
            {
                effect.Tick();
                if (effect.Duration <= 0)
                    ActiveEffects.Remove(effect);
            }
        }
    }
}
