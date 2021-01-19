using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreLibrary;

namespace Buchgeschaeft_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>() {new Book((Category)10, "Markus Ullrich", "385-2-16-538692-0", 10.00m, 10, "Wölfe und ihre lebensweiße"), new AudioBook((Category)50, 1200, "Markus Ullrich","385-2-16-538692-1", 12.00m, 15, "Das Schlagzeug und seine Entstehung"), new Newspaper(new DateTime(2020, 1, 18), 20.00m, 20, "WolfNews")};

            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();

        }
    }
}
