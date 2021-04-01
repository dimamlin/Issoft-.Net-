using System;
using System.Collections.Generic;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book a = new Book("1984", new DateTime(2001, 01, 31), "AA", "BB", "BB", "CC");
            Catalog library = new Catalog();
            library.Add("123-5-54-124345-1", a); // вводим код с минусами
            foreach (KeyValuePair<string, Book> keyValue in library.catalog)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.name);
            }
            foreach (string i in a.authors)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(library.Get("1123454423451")); // а тут сплошной, но все равно находит нужную книгу
        }
    }
}
