using System;
using System.Collections.Generic;
using System.Linq;

namespace _1EX_Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            fulfillMatrix(matrix);
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int row = 0; row < size; row++)//obhojdame matrix-a
            {
                for (int col = 0; col < size; col++)
                {
                    int number = matrix[row, col];
                    if (row==col)
                    {
                        primaryDiagonal += number;
                    }
                    if (row+col == size-1)
                    {
                        secondaryDiagonal += number;
                    }
                }
            }
            Console.WriteLine(Math.Abs(primaryDiagonal-secondaryDiagonal));
        }

        private static void fulfillMatrix(int[,] matrix)//pulnim matrix-a
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowDate = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowDate[col];
                }
            }
        }
    }
}
