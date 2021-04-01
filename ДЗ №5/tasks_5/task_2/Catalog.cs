using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task_2
{
    class Catalog 
    {
        public Dictionary<string, Book> catalog = new();

        public void Add(string ISBN, Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            string pattern = "[0-9]{3}-{0,1}[0-9]-{0,1}[0-9]{2}-{0,1}[0-9]{6}-{0,1}[0-9]";

            if (Regex.IsMatch(ISBN, pattern) && !catalog.ContainsKey(ISBN))
            {
                catalog.Add(ISBN, book);
            }
            else
            {
                throw new ArgumentNullException(nameof(book));
            }
        }

        public (string, string) Get(string ISBN)
        {
            if (ISBN == null)
            {
                throw new ArgumentNullException(nameof(ISBN));
            }

            string pattern = "[0-9]{3}-{0,1}[0-9]-{0,1}[0-9]{2}-{0,1}[0-9]{6}-{0,1}[0-9]";

            foreach(var k in catalog)
            {
                if (Regex.IsMatch(k.Key, pattern))
                {
                    return (k.Key, k.Value.name);
                }
            }

            return ("", ""); // если совпадений нет, то вернет пустую строку
        }
    }
}
