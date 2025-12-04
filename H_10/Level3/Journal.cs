using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level3
{
    internal class Journal
    {
        public List<String> journal;
        public Journal()
        {
            journal = new List<String>();
        }
        public void AddAction(string action)
        {
            journal.Add(action);
        }
        public void JournalPrint()
        {
            Console.WriteLine("---Краткая сводка---");
            foreach (var element in journal)
            {
                Console.WriteLine(element);
            }
        }
    }
}
