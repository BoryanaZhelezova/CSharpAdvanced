using System;
using System.Linq;

namespace ReverseNumber
{
    class ReverseMumber
    {
        static string ReverseDigit(string number)
        {
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            
            return new string(array);
        
        }

        static void Main()
        {
            string number = Console.ReadLine();

            Console.WriteLine(ReverseDigit(number));
        }
    }
}
