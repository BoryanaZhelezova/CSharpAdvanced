using System;

namespace HomeworkMethods
{
    class SayHello
    {
        static void SayName()
        {
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }


        static void Main(string[] args)
        {
            SayName();
        }
    }
}
