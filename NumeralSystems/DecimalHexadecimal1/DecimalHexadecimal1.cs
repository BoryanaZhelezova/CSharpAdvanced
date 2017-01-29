using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalHexadecimal1
{
    class DecimalHexadecimal1
    {
        const string HexDigits = "0123456789ABCDEF";

        static string DecimalToHex(int valueDec)
        {
            string hex = string.Empty;

            do
            {
                var value = valueDec % 16;
                hex = HexDigits[valueDec] + hex;
                valueDec /= 16;


            } while (valueDec != 0);

            return hex;
        }

        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var hexValue = DecimalToHex(num);

            Console.WriteLine(hexValue);
        }
    }
}
