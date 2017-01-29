using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Workdays
{
    class Workdays
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            DateTime endDate = DateTime.Parse(Console.ReadLine());
            DateTime[] holidays =
            {
            DateTime.Parse("05-24-2016"),
            DateTime.Parse("09-06-2016"),
            DateTime.Parse("12-24-2016")
        };

            int allWorkDays = GetWorkDays(endDate, holidays);

            Console.WriteLine(allWorkDays);
        }
        private static int GetWorkDays(DateTime date, DateTime[] holidays)
        {
            DateTime endDate = date;
            DateTime currentDate = DateTime.Today.AddDays(1);
            int workingDays = 0;

            while (currentDate <= endDate)
            {
                if (currentDate.DayOfWeek != DayOfWeek.Sunday ||
                    currentDate.DayOfWeek != DayOfWeek.Saturday ||
                  !holidays.Contains(currentDate))
                {
                    workingDays++;
                }

                currentDate = currentDate.AddDays(1);
            }

            return workingDays;
        }
    }
}
