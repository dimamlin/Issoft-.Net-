using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Vacation
    {
        public readonly string name;

        public readonly DateTime firstDay;

        public readonly DateTime lastDay;

        public Vacation(string name, DateTime firstDay, DateTime lastDay)
        {
            if(name == null || name.Length == 0)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if(firstDay > lastDay) // ставим даты в правильный порядок
            {
                DateTime temp = firstDay;
                firstDay = lastDay;
                lastDay = temp;
            }

            this.name = name;
            this.firstDay = firstDay;
            this.lastDay = lastDay;
        }
    }
}
