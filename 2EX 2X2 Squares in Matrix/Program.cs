using System;
using System.Linq;
using System.Collections.Generic;

namespace _2EX_2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split();
            int rowSize = int.Parse(sizes[0]);
            int colSize = int.Parse(sizes[1]);
            string[,] matrix = new string[rowSize, colSize];
            FulfillMatrix(matrix);
            Check2x2Matrix(matrix);

        }

        public static void Check2x2Matrix(string[,] matrix)
        {
            
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row,col]==matrix[row,col+1]
                        && matrix[row,col]==matrix[row+1,col]
                        && matrix[row,col]==matrix[row+1,col+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        private static void FulfillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowSize = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowSize[col];
                }
            }
        }
    }
}
