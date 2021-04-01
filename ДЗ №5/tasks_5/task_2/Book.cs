using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Book
    {
        public readonly string name;
        private DateTime? date { get; set; } // по условию дата публикации может быть null

        public readonly List<string> authors = new();
        
        public Book(string name, DateTime? date, params string[] authors)
        {
            if(name == null || name.Length == 0 || name.Trim() == string.Empty) 
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (date == null)
            {
                throw new ArgumentNullException(nameof(date));  // фактически дата может быть null, но создать такую книгу не получится (я так условие понял)
            }

            this.name = name;
            this.date = date;

            foreach(string i in authors)
            {
                if(i == null)
                {
                    throw new ArgumentNullException(nameof(i));
                }

                if (this.authors.Contains(i))
                {
                    continue;
                }
                else
                {
                    this.authors.Add(i);
                }
            }
        }
    }
}
