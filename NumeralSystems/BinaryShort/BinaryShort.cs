using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {
            short signedShort = short.Parse(Console.ReadLine());

            string shortToBynary = string.Empty;
            string[] binarySign = { "0", "1" };

            for (int i = 0; i < 16; i++)
            {
                var sign = binarySign[(signedShort & 1)];
                shortToBynary = sign + shortToBynary;

                /// shift right
                signedShort >>= 1;
            }

            Console.WriteLine(shortToBynary.PadLeft(16, '0'));
        }
    }
}
