using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_003
{
    class DocInfo : Document
    {
        public override void Headline()
        {
            Console.WriteLine("This is HeadLine");
        }
        public override void DocumentСontent()
        {
            Console.WriteLine("This is Doc content");
        }
        public override void Footer()
        {
            Console.WriteLine("This is footer");
        }
    }
}
