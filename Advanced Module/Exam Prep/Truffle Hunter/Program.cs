using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Drawing;

namespace Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            Dictionary<string, int> shrooms = new Dictionary<string, int>();
            shrooms.Add("B", 0);
            shrooms.Add("S", 0);
            shrooms.Add("W", 0);
            int boarShrooms = 0;
            for (int i = 0; i < size; i++)
            {
                char[] input = Console.ReadLine().Replace(" ", "").ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Stop")
            {
                if (commands[0] == "Collect")
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);

                    if (matrix[row, col] != '-')
                    {
                        char shroomType = matrix[row, col];
                        switch (shroomType)
                        {
                            case 'B':
                                shrooms["B"]++; break;
                            case 'S':
                                shrooms["S"]++; break;
                            case 'W':
                                shrooms["W"]++; break;
                            default:
                                break;
                        }
                        matrix[row, col] = '-';
                    }


                }
                else if (commands[0] == "Wild_Boar")
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);
                    string direction = commands[3];

                    boarShrooms += MoveAndCheck(direction, row, col, matrix);

                }
                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Peter manages to harvest {shrooms["B"]} black, {shrooms["S"]} summer, and {shrooms["W"]} white truffles.");
            Console.WriteLine($"The wild boar has eaten {boarShrooms} truffles.");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int MoveAndCheck(string direction, int row, int col, char[,] matrix)
        {
            int counter = 0;

            while (Checker(row, col, matrix))
            {
                if (matrix[row, col] != '-')
                {
                    counter++;
                    matrix[row, col] = '-';
                }
                switch (direction)
                {
                    case "up":
                        row -= 2;
                        break;
                    case "down":
                        row += 2;
                        break;
                    case "left":
                        col -= 2;
                        break;
                    case "right":
                        col += 2;
                        break;
                }

            }
            return counter;
        }

        public static bool Checker(int row, int col, char[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

    }
}
