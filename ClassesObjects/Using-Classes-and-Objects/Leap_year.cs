using System;

namespace Using_Classes_and_Objects
{
    class Leap_year
    {
        static int IsLeapYear(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }

            return year;
        }
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(IsLeapYear(year));

            //if (DateTime.IsLeapYear(year))
            //{
            //    Console.WriteLine("Leap");
            //}
            //else
            //{
            //    Console.WriteLine("Common");
            //}
        }
    }
}
