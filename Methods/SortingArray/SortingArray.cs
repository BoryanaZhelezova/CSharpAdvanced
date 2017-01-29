using System;
using System.Linq;

namespace SortingArray
{
    class SortingArray
    {
        static int[] ConvertToArray(string number)
        {
            int[] num = number.Split(' ').Select(int.Parse).ToArray();

            return num;
                 
        } 
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] arr = ConvertToArray(Console.ReadLine());
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));

            
        }
    }
}
