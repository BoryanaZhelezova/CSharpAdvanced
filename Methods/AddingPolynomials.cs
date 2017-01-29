using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class AddingPolynomials
    {

        static string ArraysSum(int[] a, int[] b)
        {
            int[] sum = new int[a.Length];
            
            for (int i = 0; i < a.Length; i++)
            {
                sum[i] += a[i] + b[i];
            }
            return new string(string.Join(" ", sum).ToCharArray());
        }
        static void Main()
        {
            string[] size = Console.ReadLine().Split(' ');

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
