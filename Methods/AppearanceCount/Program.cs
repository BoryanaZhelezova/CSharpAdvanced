using System;

namespace AppearanceCount
{
    class Program
    {
        static int Count(string[] input, int app, int size)
        {
            int count = 0;

            for (int i = 0; i < size - 1; i++)
            {
                if (int.Parse(input[i]) == app)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');

            int x = int.Parse(Console.ReadLine());

            int result = Count(input, x, size);
            Console.WriteLine(result);
        }
    }
}
