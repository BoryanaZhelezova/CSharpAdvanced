using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHexadecimal
{
    class Binary
    {
        static string BinaryToHex(string binary)
        {
            for (int i = 0; i < binary.Length % 4; i++)
            {
                binary = "0" + binary;
            }

            string hexNumber = string.Empty;

            for (int i = binary.Length - 1; i >= 0; i -= 4)
            {
                string fourDigits = string.Empty;

                for (int j = i; j > i - 4; j--)
                {
                    fourDigits = binary[j] + fourDigits;
                }

                switch (fourDigits)
                {
                    case "0000": hexNumber = '0' + hexNumber; break;
                    case "0001": hexNumber = '1' + hexNumber; break;
                    case "0010": hexNumber = '2' + hexNumber; break;
                    case "0011": hexNumber = '3' + hexNumber; break;
                    case "0100": hexNumber = '4' + hexNumber; break;
                    case "0101": hexNumber = '5' + hexNumber; break;
                    case "0110": hexNumber = '6' + hexNumber; break;
                    case "0111": hexNumber = '7' + hexNumber; break;
                    case "1000": hexNumber = '8' + hexNumber; break;
                    case "1001": hexNumber = '9' + hexNumber; break;
                    case "1010": hexNumber = 'A' + hexNumber; break;
                    case "1011": hexNumber = 'B' + hexNumber; break;
                    case "1100": hexNumber = 'C' + hexNumber; break;
                    case "1101": hexNumber = 'D' + hexNumber; break;
                    case "1110": hexNumber = 'E' + hexNumber; break;
                    case "1111": hexNumber = 'F' + hexNumber; break;
                }
            }

            return hexNumber;
        }

        static void Main()
        {
            var num = Console.ReadLine();
            Console.WriteLine(BinaryToHex(num));
        }
    }
}
