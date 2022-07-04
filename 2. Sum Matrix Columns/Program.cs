using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int sizeRows = sizes[0];
            int sizeCols = sizes[1];
            int[,] matrix = new int[sizeRows, sizeCols];
            for (int row = 0; row < sizeRows; row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < sizeCols; col++)
                {
                    matrix[row,col] = line[col];
                }
            }
            long[] sumCols = new long[sizeCols];
            long[] sumRows = new long[sizeRows];
            for (int row = 0; row < sizeCols; row++)
            {
                for (int col = 0; col < sizeRows; col++)
                {
                    sumCols[col] += matrix[row, col];
                }
            }
            for (int col = 0; col < sizeCols; col++)
                for (int row = 0; row < sizeRows; row++)
                {
                    sumRows[row] = matrix[row, col];
                }
            for (int row = 0; row < sizeRows; row++)
            {
                Console.WriteLine(sumRows[row]);
            }
                
            for (int col = 0; col < sizeCols; col++)
            {
                Console.WriteLine(sumCols[col]);
            }
        }
    }
}
