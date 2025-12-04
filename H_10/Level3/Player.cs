using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Level3
{
    internal class Player
    {
        private string name;
        private int health;
        public List<Spell> Spells;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Health
        {
            get
            {
                return health;
            }
        }
        public Player(string name, int health)
        {
            this.name = name;
            this.health = health;
            Spells = new List<Spell>();
        }
        public void AddSpell(Spell spell)
        {
            Spells.Add(spell);
        }
        public string SpellStatus(Spell spell)
        {
            if (spell.UseOrNot() == true)
            {
                return $"{Name} использует заклинание {spell.Name}";
            }
            else
            {
                return $"{Name} не может использовать заклинание {spell.Name}, т.к оно в кулдауне";
            }
        }
        public void UpdateAllCooldowns()
        {
            foreach (var spell in Spells)
            {
                spell.UpdateCooldown();
            }
        }
        public void TakeDamage()
        {
            int damage = 20;
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }
        public void RecoveryHealth()
        {
            int healthplus = 15;
            Health += healthplus;
            if (Health > 100)
            {
                Health = 100;
            }
        }
    }
}
