using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_004
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler abstractHandler = new DOCHandler();

            DOCHandler doc = abstractHandler as DOCHandler;
            doc.PrintInfo();
            abstractHandler.Create();
            abstractHandler.Open();
            abstractHandler.Chenge();
            abstractHandler.Save();
            Console.WriteLine();

            abstractHandler = new TXTHandler();
            TXTHandler txt = abstractHandler as TXTHandler;
            txt.PrintInfo();
            abstractHandler.Create();
            abstractHandler.Open();
            abstractHandler.Chenge();
            abstractHandler.Save();
            Console.WriteLine();

            abstractHandler = new XMLHandler();
            XMLHandler xml = abstractHandler as XMLHandler;
            xml.PrintInfo();
            abstractHandler.Create();
            abstractHandler.Open();
            abstractHandler.Chenge();
            abstractHandler.Save();

            Console.ReadKey();
        }
    }
}
