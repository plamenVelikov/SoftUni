using System;
using System.Drawing;
using System.Net.NetworkInformation;

namespace Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int vRow = 0;
            int vCol = 0;
            int holesCount = 0;
            int rodsHit = 0;
            bool isItFirstMove = true;
            bool isElectrocuted = false;
            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                    if (matrix[i, j] == 'V')
                    {
                        vRow = i;
                        vCol = j;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                int newRow = vRow;
                int newCol = vCol;
                switch (command)
                {
                    case "up":
                        newRow--; break;
                    case "down":
                        newRow++; break;
                    case "left":
                        newCol--; break;
                    case "right":
                        newCol++; break;
                }

                if (Checker(newRow, newCol, matrix))
                {
                    char symbol = matrix[newRow, newCol];
                    if (symbol == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rodsHit++;
                        if (isItFirstMove)
                        {
                            holesCount++;
                            isItFirstMove = false;
                        }

                    }
                    else if (symbol == 'C')
                    {
                        isElectrocuted = true;
                        matrix[vRow, vCol] = '*';
                        matrix[newRow, newCol] = 'E';
                        if (isItFirstMove)
                        {
                            holesCount++;
                            isItFirstMove = false;
                        }
                        holesCount++;
                        break;
                    }
                    else if (symbol == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{newRow}, {newCol}]!");
                        matrix[vRow, vCol] = '*';
                        vRow = newRow; vCol = newCol;
                        matrix[vRow, vCol] = 'V';
                        if (isItFirstMove)
                        {
                            holesCount++;
                            isItFirstMove = false;
                        }

                    }
                    else if (symbol == '-')
                    {
                        matrix[vRow, vCol] = '*';
                        vRow = newRow; vCol = newCol;
                        matrix[vRow, vCol] = 'V';
                        if (isItFirstMove)
                        {
                            holesCount++;
                            isItFirstMove = false;
                        }
                        holesCount++;
                    }
                }

                command = Console.ReadLine();
            }

            if (isElectrocuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCount} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holesCount} hole(s) and he hit only {rodsHit} rod(s).");
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

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
