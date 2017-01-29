using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static BigInteger FactorialCalculation(int[] number)
        {
            BigInteger factorial = 1;

            for (int i = 0; i < number.Length; i++)
            {
                factorial *= number[i];
            }

            return factorial;
        }

        static int[] ConvertToArray(int number)
        {
            int[] numberAsArray = new int[number];

            for (int i = 0; i < number; i++)
            {
                numberAsArray[i] = i + 1;
            }

            return numberAsArray;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = ConvertToArray(number);
            BigInteger factorial = FactorialCalculation(array);
            Console.WriteLine(factorial);
        }
    }
}
