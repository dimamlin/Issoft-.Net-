using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vacation a1 = new Vacation("Oleg", new DateTime(2021, 07, 01), new DateTime(2021, 08, 29));
            Vacation a2 = new Vacation("Oleg", new DateTime(2021, 09, 01), new DateTime(2021, 09, 25));
            Vacation a3 = new Vacation("Oleg", new DateTime(2021, 12, 03), new DateTime(2021, 12, 10));
            VacationList list = new VacationList();
            list.Add(a1);
            list.Add(a2);
            list.Add(a3);
            var enumerator1 = list.AveragePersonVacation();
            foreach (var i in enumerator1)
            {
                Console.WriteLine(i);
            }
            var enumerator2 = list.VacationCountPerMonth();
            foreach (var i in enumerator2)
            {
                Console.WriteLine(i);
            }
            var enumerator3 = list.WithOutVacationDates();
            foreach (var i in enumerator3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.AverageVacation());
            Console.WriteLine(list.IsCorrect());
        }
    }
}
