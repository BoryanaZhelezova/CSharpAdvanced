using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Sum_integers
{
    class Sum_integers
    {
        static BigInteger SumOfInts(int[] ints)
        {
            BigInteger sum = 0;

            foreach (var num in ints)
            {
                sum += num;
            }

            return sum;

        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] integers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                integers[i] = int.Parse(input[i]);
            }
            Console.WriteLine(SumOfInts(integers));


            //for (int i = 0; i < input.Length - 1; i++)
            //{
            //    int[] temp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //    sum += temp[i];
            //    sum = temp.Sum();
            //}
        }
    }
}
