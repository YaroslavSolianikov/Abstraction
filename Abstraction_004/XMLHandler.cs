using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_004
{
    class XMLHandler : AbstractHandler
    {
        public override void Chenge() => Console.WriteLine("XML file was changed");
        public override void Create() => Console.WriteLine("XML file was created");
        public override void Open() => Console.WriteLine("XML file was openned");
        public override void Save() => Console.WriteLine("XML file was saved");
        public override string Info()
        {
            return base.Info() + "XML";
        }
        public void PrintInfo()
        {
            Console.WriteLine(Info());
        }
    }
}
