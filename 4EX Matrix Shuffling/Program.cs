using System;
using System.Linq;
using System.Collections.Generic;

namespace _4EX_Matrix_Shuffling
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
            string command = Console.ReadLine();

            while (command != "END")
            {
                if (!(IsValid(command, rowSize, colSize)))
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    string[] commandParts = command.Split();
                    int row1 = int.Parse(commandParts[1]);
                    int col1 = int.Parse(commandParts[2]);
                    int row2 = int.Parse(commandParts[3]);
                    int col2 = int.Parse(commandParts[4]);

                    string firstElement = matrix[row1, col1];
                    string secondElement = matrix[row2, col2];

                    matrix[row1, col1] = secondElement;
                    matrix[row2, col2] = firstElement;
                   
                PrintMatrix(matrix);
                }
                command = Console.ReadLine();
            }
        }
        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+ " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsValid(string command, int rowSize, int colSize)
        {
            string[] commandParts = command.Split();
            if (commandParts[0] == "swap" && commandParts.Length == 5)
            {
                int row1 = int.Parse(commandParts[1]);
                int col1 = int.Parse(commandParts[2]);
                int row2 = int.Parse(commandParts[3]);
                int col2 = int.Parse(commandParts[4]);
                if (row1 >= 0 && row1 < rowSize
                    && col1 >= 0 && col1 < colSize
                    && row2 >= 0 && row2 < rowSize
                    && col2 >= 0 && col2 < colSize)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {

                return false;
            }
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
