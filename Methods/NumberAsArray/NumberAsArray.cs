using System;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static string ArraysSum(int[] a, int[] b)
        {
            int sum = 0;
            int remainder = 0;
            string result = string.Empty;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] + b[i] + remainder > 9)
                {
                    sum = a[i] + b[i] + remainder - 10;
                    remainder = 1;
                    
                }
                else
                {
                    sum = a[i] + b[i] + remainder;
                    remainder = 0;
                }
                result += sum;
                sum = 0;
            }

            if (remainder == 1)
            {
                result += remainder;
            }
            return string.Join(" ", result.ToCharArray());
        }
        static void Main()
        {
            string[] sizes = Console.ReadLine().Split(' ');

            string[] num1 = Console.ReadLine().Split(' ');
            string[] num2 = Console.ReadLine().Split(' ');

            int[] first = new int[Math.Max(num1.Length, num2.Length)];
            int[] second = new int[Math.Max(num1.Length, num2.Length)];

            for (int i = 0; i < num1.Length; i++)
            {
                first[i] = int.Parse(num1[i]);

            }
            for (int i = 0; i < num2.Length; i++)
            {
                second[i] = int.Parse(num2[i]);
            }
            Console.WriteLine(ArraysSum(first, second));
        }
    }
}
