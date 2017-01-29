using System;

namespace Triangle_surfaceThreeSides
{
    class Triangle_surfaceThreeSides
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double s = (a + b + c) / 2;

            double surface = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
