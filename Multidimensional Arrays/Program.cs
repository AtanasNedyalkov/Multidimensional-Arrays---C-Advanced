using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rowCount = dimensions[0];//3
            int colCount = dimensions[1];//6
            int[,] matrix = new int[rowCount, colCount];
            for (int row = 0; row < rowCount; row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < colCount; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            long sum = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(rowCount);
            Console.WriteLine(colCount);
            Console.WriteLine(sum);
        }
    }
}
