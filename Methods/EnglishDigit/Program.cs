using System;

namespace EnglishDigit
{
    class Program
    {
        static void Main()
        {
            var number = Console.ReadLine();
            Console.WriteLine(LastDigitInEnglish(number));
        }

        static string LastDigitInEnglish(string number)
        {
            var english = string.Empty;

            var lastDigit = number[number.Length - 1] - '0';

            switch (lastDigit)
            {
                case 0: english = "zero"; break;
                case 1: english = "one"; break;
                case 2: english = "two"; break;
                case 3: english = "three"; break;
                case 4: english = "four"; break;
                case 5: english = "five"; break;
                case 6: english = "six"; break;
                case 7: english = "seven"; break;
                case 8: english = "eight"; break;
                case 9: english = "nine"; break;
            }

            return english;
        }


        //static string LastDigitInEnglish(string input)
        //{

        //    switch (input[input.Length - 1])
        //    {
        //        case '0': return "zero"; break;
        //        case '1': return "one"; break;
        //        case '2': return "two"; break;
        //        case '3': return "three"; break;
        //        case '4': return "four"; break;
        //        case '5': return "five"; break;
        //        case '6': return "six"; break;
        //        case '7': return "seven"; break;
        //        case '8': return "eight"; break;
        //        case '9': return "nine"; break;

        //    }
        //    return "error";
        //}

        //static void Main()
        //{
        //    string input = Console.ReadLine();

        //    Console.WriteLine(LastDigitInEnglish(input));

    }
}


