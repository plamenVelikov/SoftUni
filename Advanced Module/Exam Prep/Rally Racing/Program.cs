using System;
using System.Collections.Generic;

namespace Rally_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string raceCarNumber = Console.ReadLine();
            char[,] matrix = new char[size, size];
            int row = 0;
            int col = 0;
            List<int> tList = new List<int>();
            int counterKms = 0;
            bool carWon = false;

            for (int i = 0; i < size; i++)
            {
                char[] input = Console.ReadLine().Replace(" ", "").ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];


                    if (matrix[i, j] == 'T')
                    {
                        tList.Add(i);
                        tList.Add(j);
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {

                int newRow = row;
                int newCol = col;

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

                char symbol = matrix[newRow, newCol];

                if (symbol == '.')
                {
                    counterKms += 10;
                    row = newRow;
                    col = newCol;
                }
                else if (symbol == 'T')
                {
                    if (newRow == tList[0] && newCol == tList[1])
                    {

                        matrix[newRow, newCol] = '.';
                        row = tList[2];
                        col = tList[3];
                        matrix[row, col] = '.';
                        counterKms += 30;
                    }
                    else if (newRow == tList[2] && newCol == tList[3])
                    {
                        matrix[newRow, newCol] = '.';
                        row = tList[0];
                        col = tList[1];
                        matrix[row, col] = '.';
                        counterKms += 30;

                    }
                }
                else if (symbol == 'F')
                {
                    row = newRow;
                    col = newCol;
                    counterKms += 10;
                    carWon = true;
                    break;
                }

                command = Console.ReadLine();
            }

            if (carWon)
            {
                Console.WriteLine($"Racing car {raceCarNumber} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {raceCarNumber} DNF.");
            }

            Console.WriteLine($"Distance covered {counterKms} km.");

            matrix[row, col] = 'C';

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
