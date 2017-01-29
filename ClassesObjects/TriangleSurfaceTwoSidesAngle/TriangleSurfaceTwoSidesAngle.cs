using System;

namespace TriangleSurfaceTwoSidesAngle
{
    class TriangleSurfaceTwoSidesAngle
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double degrees = double.Parse(Console.ReadLine());

            double angle = Math.PI * degrees / 180.0;
            double sinAngle = Math.Sin(angle);

            double surface = (a * b * sinAngle) / 2;

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
