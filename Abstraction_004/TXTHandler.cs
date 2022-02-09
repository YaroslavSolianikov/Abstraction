using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_004
{
    class TXTHandler : AbstractHandler
    {
        public override void Chenge() => Console.WriteLine("TXT file was changed");
        public override void Create() => Console.WriteLine("TXT file was created");
        public override void Open() => Console.WriteLine("TXT file was openned");
        public override void Save() => Console.WriteLine("TXT file was saved");
        public override string Info()
        {
            return base.Info() + "TXT";
        }
        public void PrintInfo()
        {
            Console.WriteLine(Info());
        }
    }
}
