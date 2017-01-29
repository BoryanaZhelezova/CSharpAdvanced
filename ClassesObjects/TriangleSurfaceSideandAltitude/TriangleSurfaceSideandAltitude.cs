using System;

namespace TriangleSurfaceSideandAltitude
{
    class TriangleSurfaceSideandAltitude
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());

            double surface = (a * ha) / 2;

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
