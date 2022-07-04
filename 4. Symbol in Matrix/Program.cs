using System;
using System.Linq;
using System.Text;
namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            FilMatrix(matrix, size);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    if (!char.IsLetterOrDigit(currentSymbol))
                    {
                        Console.WriteLine(String.Join(", ", matrix[row, col]));
                    }
                }
            }
        }

        private static void FilMatrix(int[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                string rowDate = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    char currentSymbol = rowDate[col];
                    matrix[row, col] = currentSymbol;
                   
                }
            }
        }
    }
}
