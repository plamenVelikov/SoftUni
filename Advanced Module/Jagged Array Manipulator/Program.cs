using System;
using System.Linq;
using System.Windows.Input;

namespace Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] inputRows = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[i] = inputRows;
            }

            for (int i = 0; i < rows - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for (int z = 0; z < matrix[i].Length; z++)
                    {
                        matrix[i][z] *= 2;
                        matrix[i + 1][z] *= 2;
                    }
                }
                else
                {

                    for (int f = 0; f < matrix[i].Length; f++)
                    {
                        matrix[i][f] /= 2;
                    }
                    for (int g = 0; g < matrix[i + 1].Length; g++)
                    {
                        matrix[i + 1][g] /= 2;
                    }
                }
            }


            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= rows)
                        {
                            if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < matrix[int.Parse(command[1])].Length)
                            {
                                matrix[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                            }
                        }
                        break;
                    case "Subtract":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= rows)
                        {
                            if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < matrix[int.Parse(command[1])].Length)
                            {
                                matrix[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                            }
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int z = 0; z < matrix[i].Length; z++)
                {
                    Console.Write($"{matrix[i][z]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
