using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class Mage : Character
    {
        private List<Spell> spellBook;

        public Mage(string name) : base(name, 100)
        {
            spellBook = new List<Spell>();
        }

        public void AddSpell(Spell spell)
        {
            spellBook.Add(spell);
            Console.WriteLine($"{Name} получил заклинание: {spell.Name}");
        }

        public void ShowSpellBook()
        {
            Console.WriteLine($"Книга заклинаний {Name}:");
            for (int i = 0; i < spellBook.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                spellBook[i].ShowInfo();
            }
        }

        public void CastSpell(int spellIndex, Character target)
        {
            if (is_Alive == false)
            {
                Console.WriteLine($"{Name} умер и не может получать заклинания");
                return;
            }

            if (spellIndex < 1 || spellIndex > spellBook.Count)
            {
                Console.WriteLine("Неверный номер заклинания");
                return;
            }

            Spell spell = spellBook[spellIndex - 1];
            Console.WriteLine($"\n{Name} применяет {spell.Name} на {target.Name}");
            spell.Cast(this, target);
        }

        public int SpellsCount => spellBook.Count;
    }
}
