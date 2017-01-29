using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalDecimal
{
    class HexadecimalDecimal
    {
        static long HexToDecimal(string hex)
        {
            long pow = 1;

            long dec = 0;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                long hexDigit;

                switch (hex[i])
                {
                    case 'A': hexDigit = 10; break;
                    case 'B': hexDigit = 11; break;
                    case 'C': hexDigit = 12; break;
                    case 'D': hexDigit = 13; break;
                    case 'E': hexDigit = 14; break;
                    case 'F': hexDigit = 15; break;
                    default: hexDigit = hex[i] - '0'; break;
                }

                dec += hexDigit * pow;
                pow *= 16; //mutiplies by 2
            }

            return dec;
        }

        static void Main()
        {
            string x = Console.ReadLine();
            Console.WriteLine(HexToDecimal(x));
        }
    }
}
