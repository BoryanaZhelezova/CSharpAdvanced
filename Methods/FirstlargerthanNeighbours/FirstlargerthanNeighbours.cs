using System;

namespace FirstlargerthanNeighbours
{
    class FirstlargerthanNeighbours
    {

        static int PrintLargerNeighbour(int[] array)
        {
            
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            string[] input = new string[size];

            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            Console.WriteLine(PrintLargerNeighbour(arr));
        }
    }
}
