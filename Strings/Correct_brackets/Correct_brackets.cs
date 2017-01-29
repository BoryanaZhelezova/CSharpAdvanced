using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correct_brackets
{
    class Correct_brackets
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            int counterInt = 0;
            int counterEnd = 0;


            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    counterInt++;
                }
                else if (expression[i] == ')' )
                {
                    counterEnd++;
                }

            }
            if (counterInt == counterEnd)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
                
        }
    }
}
