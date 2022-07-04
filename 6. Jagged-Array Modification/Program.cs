using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rowsCount][];
            for (int row = 0; row < rowsCount; row++)
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "Add"|| command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int val = int.Parse(command[3]);
                    if (command[0]=="Subtract")
                    {
                        val = -val;
                    }
                    if (row>=0 && row< jagged.Length && col>=0 && col <jagged[row].Length)
                    {
                        jagged[row][col] += val;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

            }
            //Print jagged array
            for (int row = 0; row < rowsCount; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }
    }
}
