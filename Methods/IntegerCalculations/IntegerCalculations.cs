using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static long ProductCalculation(int[] arr)
        {
            long product = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
           
            return product;
        }

        static int SumCalculation(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static decimal AverageCalculation(int[] arr)
        {
            decimal avg = 0;

            avg = SumCalculation(arr) /(decimal)arr.Length;

            return avg;
        }

        static int MaximumCalculations(int[] arr)
        {
            int max = int.MinValue;

            Array.Sort(arr);
            max = arr[arr.Length - 1];

            return max;
        }

        static int MinimumCalculations(int[] arr)
        {
            int min = int.MinValue;
            Array.Sort(arr);
            min = arr[0];

            return min;

        }
        static int[] ConvertToArray(string number)
        {
            int[] num = number.Split(' ').Select(int.Parse).ToArray();

            return num;

        }
        static void Main()
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            //int length = int.Parse(Console.ReadLine());

            int[] arr = ConvertToArray(Console.ReadLine());
            
            //Console.WriteLine(string.Join(" ", arr));

            Console.WriteLine(MinimumCalculations(arr));
            Console.WriteLine(MaximumCalculations(arr));
            Console.WriteLine("{0:F2}", AverageCalculation(arr));
            Console.WriteLine(SumCalculation(arr));
            Console.WriteLine(ProductCalculation(arr));
        }
    }
}
