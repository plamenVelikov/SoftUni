using System;
using System.Linq;

namespace Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int z = 0; z < sizes[1]; z++)
                {
                    matrix[i, z] = input[z];
                }
            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {

                if (command.Count() == 5)
                {
                    switch (command[0])
                    {

                        case "swap":
                            if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < sizes[0] && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < sizes[1] && int.Parse(command[3]) >= 0 && int.Parse(command[3]) < sizes[0] && int.Parse(command[4]) >= 0 && int.Parse(command[4]) < sizes[1])
                            {
                                string firstLocSaved = matrix[int.Parse(command[1]), int.Parse(command[2])];
                                matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];
                                matrix[int.Parse(command[3]), int.Parse(command[4])] = firstLocSaved;

                                for (int i = 0; i < sizes[0]; i++)
                                {
                                    for (int z = 0; z < sizes[1]; z++)
                                    {
                                        Console.Write($"{matrix[i, z]} ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input!");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
