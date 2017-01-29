using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeral_SystemsHomework
{
    class DecimalToBinary
    {
        static string DecToBin(long decValue)
        {
            string binary = string.Empty;

            do
            {
                long bit = decValue % 2;
                binary = bit + binary;
                decValue /= 2;

            } while (decValue != 0);

            return binary;
        }
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(DecToBin(num));
        }
    }
}
