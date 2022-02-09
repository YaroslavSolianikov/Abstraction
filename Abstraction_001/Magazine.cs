using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_001
{
    class Magazine : IPrintable
    {
        public string Name { get; set; }
        public IPrintable[] printable { get; set; }
        public void Print()
        {
            foreach (IPrintable item in printable)
            {
                item.Print();
            }
        }
    }     
    
}
