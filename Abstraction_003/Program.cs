using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new DocInfo();
            document.Headline();
            document.DocumentСontent();
            document.Footer();
            Console.ReadKey();
        }
    }
}
