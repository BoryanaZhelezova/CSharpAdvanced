﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static long BinToDec(string binary)
        {
            long sum = 0;

            foreach (char bit in binary)
            {
                sum = (bit - '0') + sum * 2;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            Console.WriteLine(BinToDec(num));    
        }
    }
}
