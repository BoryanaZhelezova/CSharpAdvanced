using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[,] matrix = new int[n, m];
        int[,] subMatrix = new int[3, 3];

        for (int i = 0; i < n; i++)
        {
            int[] temp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = temp[j];
            }
            Array.Clear(temp, 0, temp.Length);
        }

        int maxSum = int.MinValue;

        int tempMaxSum = 0;

        for (int i = 0; i < n-2; i++)
        {
            for (int j = 0; j < m-2; j++)
            {
                for (int subRow = i; subRow < i+3; subRow++)
                {
                    for (int subCol = j; subCol < j+3; subCol++)
                    {
                        tempMaxSum += matrix[subRow, subCol];
                    }
                }
                if (tempMaxSum >maxSum)
                {
                    maxSum = tempMaxSum;
                }
                tempMaxSum = 0;
            }
        }
        Console.WriteLine(maxSum);
    }
}

