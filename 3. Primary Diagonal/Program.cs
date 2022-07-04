using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            FulfilMatrix(matrix, size);
            int primaryDiagonalSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int number = matrix[row, col];
                    if (row==col)
                    {
                        primaryDiagonalSum += number;
                    }
                }
            }
            Console.WriteLine(primaryDiagonalSum);
        }

        private static void FulfilMatrix(int[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                int[] rowDate = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowDate[col];
                }
            }
        }
    }
}
