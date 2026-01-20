using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3levelsred
{
    internal class BattleLog
    {
        private readonly List<BattleLogEntry> _entries;

        public BattleLog()
        {
            _entries = new List<BattleLogEntry>();
        }

        public void Add(string actor, string action, int value, List<string> effects, int targetHealth)
        {
            _entries.Add(new BattleLogEntry
            {
                Actor = actor,
                Action = action,
                Value = value,
                Effects = effects,
                TargetHealth = targetHealth
            });
        }

        public void Print()
        {
            Console.WriteLine("\n--- журнал боя ---\n");
            foreach (var entry in _entries)
            {
                Console.WriteLine($"{entry.Actor} использует {entry.Action}, значение: {entry.Value}, здоровье цели: {entry.TargetHealth}");
                if (entry.Effects.Any())
                    Console.WriteLine("  Эффекты: " + string.Join(", ", entry.Effects));
            }
        }
        public void PrintSummary(Character hero, Character monster)
        {
            Console.WriteLine("\n--- сводка ---");
            Console.WriteLine($"{hero.Name}: {hero.Health}/{hero.MaxHealth} HP");
            Console.WriteLine($"{monster.Name}: {monster.Health}/{monster.MaxHealth} HP");

            string winner;
            if (hero.IsAlive())
            {
                winner = hero.Name;
            }
            else
            {
                winner = monster.Name;
            }
            Console.WriteLine($"Победитель: {winner}");
        }

    }
}
