using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceMatrix
{
    class SequenceMatrix
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] matrix = new int[n, m];

            // read
            for (int row = 0; row < n; row++)
            {
                string[] nums = Console.ReadLine().Split(' ');

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = Convert.ToInt32(nums[col]);
                }
            }

            int seq = 1;
            int longest = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    //right
                    for (int j = col + 1; j < m; j++)
                    {
                        if (matrix[row, col] == matrix[row, j])
                        {
                            seq++;
                        }
                    }

                    if (seq > longest)
                    {
                        longest = seq;
                    }

                    seq = 1;
                    //downwards
                    for (int i = row + 1; i < n; i++) 
                    {
                        if (matrix[row, col] == matrix[i, col])
                        {
                            seq++;
                        }
                    }

                    if (seq > longest)
                    {
                        longest = seq;
                    }

                    seq = 1;

                    //right diagonal
                    for (int i = row + 1, j = col + 1; i < n && j < m; i++, j++)
                    {
                        if (matrix[row, col] == matrix[i, j])
                        {
                            seq++;
                        }
                    }

                    if (seq > longest)
                    {
                        longest = seq;
                    }

                    seq = 1;

                    //left diagonal
                    for (int i = row + 1, j = col - 1; i < n && j >= 0; i++, j--)
                    {
                        if (matrix[row, col] == matrix[i, j])
                        {
                            seq++;
                        }
                    }

                    if (seq > longest)
                    {
                        longest = seq;
                    }

                    seq = 1;
                }
            }

            Console.WriteLine(longest);

        }
    }
}
