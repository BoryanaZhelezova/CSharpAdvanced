using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring_in_text
{
    class Substring_in_text
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine().ToLower();
            string quote = Console.ReadLine().ToLower();

            int counter = 0;

            int index = quote.IndexOf(keyword);

            while (index != -1)
            {
                //Console.WriteLine("{0} found at index: {1}", keyword, index);
                index = quote.IndexOf(keyword, index + keyword.Length);
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
