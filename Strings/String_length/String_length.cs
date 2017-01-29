using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String_length
{
    class String_length
    {
        static void Main()
        {
            string text = Console.ReadLine();
            Console.WriteLine(text.PadRight(20, '*'));
        }
    }
}
