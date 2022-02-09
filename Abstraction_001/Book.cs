using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_001
{
    class Book : IPrintable
    {
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine(Name);   
        }
        public void PrintBooks(IPrintable[] printable)
        {
            IPrintable printable1 = new Book();
            Console.WriteLine();
            Console.WriteLine("Only books");

            foreach (var item in printable)
            {
                printable1 = item;
                Book book = printable1 as Book;
                if (item == book)
                {
                    book.Print();
                }
            }
        }
    }
}
