using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_001
{
    class Program
    {
        static void Main(string[] args)
        { 
            Book book1 = new Book() { Name = "Book1" };
            Book book2 = new Book() { Name = "Book2" };
            Book book3 = new Book() { Name = "Book3" };
            Book book = new Book();

            Journal journal1 = new Journal() { Name = "Journal1" };
            Journal journal2 = new Journal() { Name = "Journal2" };
            Journal journal3 = new Journal() { Name = "Journal3" };
            Journal journal = new Journal();

            Magazine magazine = new Magazine();
            IPrintable[]magazines = new IPrintable[] { book1, book2, book3, journal1, journal2, journal3 };
            magazine.printable = magazines;
            magazine.Print();
            book.PrintBooks(magazine.printable);
            journal.PrintJournals(magazine.printable);
            Console.ReadKey();
        }
    }
}
