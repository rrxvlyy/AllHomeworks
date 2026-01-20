using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3levelsred
{
    internal class Effect
    {
        public string Description { get; }
        public int Duration { get; private set; }

        public Effect(string description, int duration)
        {
            Description = description;
            Duration = duration;
        }

        public void Tick()
        {
            Duration--;
        }
    }
}
