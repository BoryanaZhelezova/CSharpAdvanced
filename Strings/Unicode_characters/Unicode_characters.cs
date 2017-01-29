using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_characters
{
    class Unicode_characters
    {
        static string ConvertToUnicode(string str)
        {
            //StringBuilder utf = new StringBuilder(str.Length * 6);
            StringBuilder utf = new StringBuilder(str.Length);
            foreach (char c in str)
                utf.AppendFormat("\\u{0:X4}", (int)c);

            return utf.ToString();
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Console.WriteLine(ConvertToUnicode(str));
        }
    }
}
