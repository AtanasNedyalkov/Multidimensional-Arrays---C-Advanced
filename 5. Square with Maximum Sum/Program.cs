using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int Rowsize = sizes[0];//3
            int Colsize = sizes[1];//6
            int [,] matrix = new int[Rowsize, Colsize];
            for (int row = 0; row < Rowsize; row++)//1---7, 1, 3, 3, 2, 1
            {                                      //2---1, 3, 9, 8, 5, 6
                                                   //3---4, 6, 7, 9, 1, 0   
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();//7, 1, 3, 3, 2, 1

                for (int col = 0; col < Colsize; col++)
                {
                    matrix[row, col] = line[col];//1--7, 1, 3, 3, 2, 1
                }
            }
            int maxSum = int.MinValue;
            //string bestSquare2x2 = string.Empty;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < Rowsize-1; row++)
            {
                for (int col = 0; col < Colsize-1; col++)
                {
                    var newSquareSum = matrix[row, col] +
                                       matrix[row+1, col] +
                                       matrix[row , col+1] +
                                       matrix[row + 1, col + 1];
                    if (newSquareSum>maxSum)
                    {
                        maxSum = newSquareSum;
                        bestRow = row;
                        bestCol = col;
                        //bestSquare2x2 = matrix[row, col] + " " + matrix[row + 1, col] + "\r\n" +
                        //               matrix[row, col + 1] + " " + matrix[row + 1, col + 1];
                        
                    }
                }
            }
            //Console.WriteLine(bestSquare2x2);
            Console.WriteLine(matrix[bestRow, bestCol] + " " + matrix[bestRow + 1, bestCol]);
            Console.WriteLine(matrix[bestRow, bestCol+1] + " " + matrix[bestRow + 1, bestCol+1]);
            Console.WriteLine(maxSum);
        }
    }
}
