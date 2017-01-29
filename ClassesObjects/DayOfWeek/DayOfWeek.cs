using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now.DayOfWeek;
            Console.WriteLine(today);
        }
    }
}
