using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            try
            {
                double number = double.Parse(input);
                if (number >= 0)
                {
                    double result = Math.Sqrt(number);
                    Console.WriteLine("{0:F3}", result);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("number", "Number must be positive!");
                }
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
