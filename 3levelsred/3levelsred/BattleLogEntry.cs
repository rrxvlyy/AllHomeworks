using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3levelsred
{
    internal class BattleLogEntry
    {
        public string Actor { get; set; }
        public string Action { get; set; }
        public int Value { get; set; }
        public List<string> Effects { get; set; }
        public int TargetHealth { get; set; }
    }
}
