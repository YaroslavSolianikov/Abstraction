using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_004
{
    class DOCHandler : AbstractHandler
    {
        public override void Chenge() => Console.WriteLine("DOC file was changed");
        public override void Create() => Console.WriteLine("DOC file was created");
        public override void Open() => Console.WriteLine("DOC file was openned");
        public override void Save() => Console.WriteLine("DOC file was saved");
        public override string Info()
        {
            return base.Info() + "doc";
        }
        public void PrintInfo()
        {
            Console.WriteLine(Info());
        }
    }
}
