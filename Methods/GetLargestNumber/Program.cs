using System;

namespace GetLargestNumber
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            int result1 = GetMax(int.Parse(input[0]), int.Parse(input[1]));
            int result2 = GetMax(result1, int.Parse(input[2]));

            Console.WriteLine(result2);

        }
    }
}
