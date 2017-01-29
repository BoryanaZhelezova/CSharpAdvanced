using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class FillMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            char input = char.Parse(Console.ReadLine());

            int counter = 1;

            if (input == 'a')
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[j, i] = counter++;
                    }
                }
            }
            else if (input == 'b')
            {
                for (int i = 0; i < n; i++)
                {
                    if ((i % 2) == 0)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matrix[j, i] = counter++;
                        }
                    }
                    else
                    {
                        for (int j = n - 1; j >= 0; j--)
                        {
                            matrix[j, i] = counter++;
                        }
                    }
                }
            }
            else if (input == 'c')
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    for (int i = 0; i < n - j; i++)
                    {
                        matrix[j + i, i] = counter++;
                    }
                }
                for (int i = 1; i < n; i++)
                {
                    for (int j = 0; j < n - i; j++)
                    {
                        matrix[j, i + j] = counter++;
                    }
                }
            }
            else if (input == 'd')
            {
                for (int depth = 0; depth <= (n / 2); depth++)
                {
                    for (int down = depth; down <= n - depth - 1; down++, counter++)
                    {
                        matrix[down, depth] = counter;
                    }
                    for (int right = depth + 1; right <= n - depth - 1; right++, counter++)
                    {
                        matrix[(n - depth - 1), right] = counter;
                    }
                    for (int up = n - depth - 2; up > depth; up--, counter++)
                    {
                        matrix[up, (n - depth - 1)] = counter;
                    }
                    for (int left = n - depth - 1; left > depth; left--, counter++)
                    {
                        if (matrix[depth, left] == 0)
                        {
                            matrix[depth, left] = counter;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Input invalid");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j>0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("{0}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
