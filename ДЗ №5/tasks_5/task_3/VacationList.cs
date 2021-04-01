using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class VacationList
    {
        private readonly List<Vacation> list = new();

        public void Add(Vacation vacation)
        {
            if(vacation == null)
            {
                throw new ArgumentNullException(nameof(vacation));
            }

            list.Add(vacation);
        }

        public int AverageVacation()
        {
            var averageVacation = from t in list
                                  select new
                                  {
                                      averageVacation = (t.lastDay - t.firstDay).Days
                                  };

            int allSum = 0;

            foreach(var k in averageVacation)
            {
                allSum += k.averageVacation;
            }

            return allSum / averageVacation.Count();
        }

        public IEnumerable AveragePersonVacation()
        {
            var averagePersonVacation = from t in list
                                        select new
                                        {
                                            name = t.name,
                                            averageVacation = (t.lastDay - t.firstDay).Days
                                        };

            return averagePersonVacation;
        }

        public IEnumerable VacationCountPerMonth()
        {
            List<(int, int)> personsPerMonth = new();

            for (int i = 0; i < 12; i++)
            {
                var vacationCountPerMount = from t in list
                                            where t.firstDay.Month == i || t.lastDay.Month == i
                                            select t;
                foreach(var k in vacationCountPerMount)
                {
                    personsPerMonth.Add((i, vacationCountPerMount.Count()));
                }
            }

            return personsPerMonth;
        }

        public IEnumerable WithOutVacationDates()
        {
            List<DateTime> dates = new();
            DateTime begin = new(2021, 01, 01);
            DateTime end = new(2021, 12, 31);

            for(; begin < end; begin.AddDays(1))
            {
                

                var withVacationsDates = from t in list
                                         select t;
                bool noVacation = true;

                foreach(var k in withVacationsDates)
                {
                    if(begin > k.firstDay && begin < k.lastDay)
                    {
                        noVacation = false;
                        break;
                    }
                }

                if(noVacation)
                {
                    dates.Add(begin);
                }
            }

            return dates;
        }

        public bool IsCorrect()
        {
            var personVacation = from t in list
                                 group t by t.name;

            foreach(var k in personVacation)
            {
                List<DateTime> commonDates = new List<DateTime>();
                foreach(var t in k)
                {
                    DateTime end = t.lastDay;
                    for (DateTime begin = t.firstDay; begin < end; begin.AddDays(1))
                    {
                        commonDates.Add(begin);
                    }
                }
                if(commonDates != commonDates.Distinct())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
