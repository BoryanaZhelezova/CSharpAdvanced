using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Extract_sentences
{
    class Extract_sentences
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            Console.WriteLine(Extract(text, keyword));


        }
        public static string Extract(string str, string keyword)
        {
            string[] arr = str.Split('.');
            string answer = string.Empty;

            foreach (string sentence in arr)
            {
                //Add any other required punctuation characters for splitting words in the sentence
                string[] words = sentence.Split(new char[] { ' ', ',' , '.'});
                if (words.Contains(keyword))
                {
                    answer += sentence;
                }
            }

            return answer;
        }
    }
}