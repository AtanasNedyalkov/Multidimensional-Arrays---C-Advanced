using System;
using System.Linq;

namespace _3Ex_Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizes = Console.ReadLine();
            int rows = int.Parse(sizes.Split()[0]);
            int cols = int.Parse(sizes.Split()[1]);
            int[,] matrix = new int[rows, cols];
            FilMatrix(matrix, rows, cols);
            int maxSum = int.MinValue;
            string bestSquare = string.Empty;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    var newSquareSum = matrix[row, col] +
                                       matrix[row, col + 1] +
                                       matrix[row, col + 2] +
                                       matrix[row + 1, col] + 
                                       matrix[row + 1, col + 1] + 
                                       matrix[row + 1, col + 2] +
                                       matrix[row + 2, col] + 
                                       matrix[row + 2, col + 1] + 
                                       matrix[row + 2, col + 2];
                    if (newSquareSum > maxSum)
                    {
                        maxSum = newSquareSum;
                        bestSquare =   matrix[row, col] + " " +
                                       matrix[row, col + 1] + " " +
                                       matrix[row, col + 2] + " " + "\r\n" +
                                       matrix[row + 1, col] + " " + 
                                       matrix[row + 1, col + 1] + " " +
                                       matrix[row + 1, col + 2] + " " + "\r\n" +
                                       matrix[row + 2, col] + " " +
                                       matrix[row + 2, col + 1] + " " +
                                       matrix[row + 2, col + 2];
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(bestSquare);
        }

        private static void FilMatrix(int[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] rowSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowSize[col];
                }
            }
        }
    }
}
