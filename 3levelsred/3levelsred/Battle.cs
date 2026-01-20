using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3levelsred
{
    internal class Battle
    {
        private readonly Character _hero;
        private readonly Character _monster;
        private readonly BattleLog _log;
        private readonly Random _random;

        public Battle(Character hero, Character monster)
        {
            _hero = hero;
            _monster = monster;
            _log = new BattleLog();
            _random = new Random();
        }

        public void Start()
        {
            int round = 1;
            while (_hero.IsAlive() && _monster.IsAlive())
            {
                Console.WriteLine($"\n--- Раунд {round} ---");

                TakeTurn(_hero, _monster);
                if (_monster.IsAlive() == false)
                {
                    break;
                }

                TakeTurn(_monster, _hero);

                _hero.UpdateCooldowns();
                _monster.UpdateCooldowns();
                _hero.UpdateEffects();
                _monster.UpdateEffects();

                round++;
            }

            _log.Print();
            _log.PrintSummary(_hero, _monster);
        }

        private void TakeTurn(Character attacker, Character target)
        {
            var availableSpells = attacker.Spells.Where(s => s.CanUse()).ToList();
            if (!availableSpells.Any())
            {
                Console.WriteLine($"{attacker.Name} пропускает ход (все заклинания на перезарядке)");
                return;
            }

            Spell spell = availableSpells[_random.Next(availableSpells.Count)];
            spell.Use();

            List<string> effects = new List<string>();

            if (spell.Power > 0)
            {
                target.TakeDamage(spell.Power);
                Console.WriteLine($"{attacker.Name} наносит {spell.Power} урона заклинанием {spell.Name}");
            }
            else
            {
                attacker.Heal(-spell.Power);
                Console.WriteLine($"{attacker.Name} лечится на {-spell.Power} с помощью {spell.Name}");
            }

            _log.Add(attacker.Name, spell.Name, spell.Power, effects, target.Health);
        }
    }
}
