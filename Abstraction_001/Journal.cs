using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_001
{
    class Journal : IPrintable
    {
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine(Name);
        }
        public void PrintJournals(IPrintable[] printable)
        {
            IPrintable printable1 = new Journal();
            Console.WriteLine();
            Console.WriteLine("Only Journals");

            foreach (var item in printable)
            {
                printable1 = item;
                Journal journal = printable1 as Journal;
                if (item == journal)
                {
                    journal.Print();
                }
            }
        }
    }
}
