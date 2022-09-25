using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = input;
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "END")
            {

                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                switch (commands[0])
                {
                    case "Add":
                        if (row >= 0 && row < numRows && col >= 0 && col < matrix[row].Length)
                        {
                            matrix[row][col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "Subtract":
                        if (row >= 0 && row < numRows && col >= 0 && col < matrix[row].Length)
                        {
                            matrix[row][col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    default:
                        break;
                }
                commands = Console.ReadLine().Split();
            }

            for (int i = 0; i < numRows; i++)
            {
                foreach (var item in matrix[i])
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

        }
    }
}
