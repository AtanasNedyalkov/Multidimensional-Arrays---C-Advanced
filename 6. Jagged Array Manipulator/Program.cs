using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[numberOfRows][];
            for (int row = 0; row < numberOfRows; row++)
            {
                //10 20 30
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            for (int row = 0; row < numberOfRows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(el => el * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(el => el * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(el => el / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(el => el / 2).ToArray();
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                //"Add {row} {column} {value}" - add {value}
                //"Subtract {row} {column} {value}" - subtract {value} 
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);
                int value = int.Parse(command.Split()[3]);
                if (row >= 0 && row < numberOfRows
                    && col >= 0 && col < matrix[row].Length)
                {
                    if (command.StartsWith("Add"))
                    {
                        matrix[row][col] += value;
                    }
                    else if (command.StartsWith("Subtract"))
                    {
                        matrix[row][col] -= value;
                    }

                }

                command = Console.ReadLine();
            }
            //foreach (int[] row in matrix)
            //{
            //    Console.WriteLine(String.Join(' ', row));
            //}
            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
