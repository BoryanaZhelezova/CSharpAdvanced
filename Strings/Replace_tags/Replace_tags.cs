using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Replace_tags
{
    class Replace_tags
    {
        static void Main(string[] args)
        {
            string html = Console.ReadLine();

            Console.WriteLine(Regex.Replace(html, "<a href=\"(.*?)\">(.*?)</a>", "[$2]($1)"));
        }
    }
}
