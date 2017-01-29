using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_numbers
{
    class Random_numbers
    {
        static void Main()
        {
            Random numberGenerator = new Random();

            for (int i = 0; i < 10; i++)
            {
                var rand = numberGenerator.Next(100, 201);
                Console.WriteLine(rand);
            }

            
        }
    }
}
