using System;
using System.Drawing;
using System.Numerics;

namespace Re_Volt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int numCommands = int.Parse(Console.ReadLine());
            int fRow = 0;
            int fCol = 0;
            bool hasWon = false;
            char[,] matrix = new char[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                    if (input[j] == 'f')
                    {
                        fRow = i;
                        fCol = j;
                    }
                }
            }


            for (int i = 0; i < numCommands; i++)
            {
                string direction = Console.ReadLine();

                int newRow = fRow;
                int newCol = fCol;

                switch (direction)
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


                if (newRow < 0) newRow = matrixSize - 1;
                if (newRow == matrixSize) newRow = 0;
                if (newCol < 0) newCol = matrixSize - 1;
                if (newCol == matrixSize) newCol = 0;

                char symbol = matrix[newRow, newCol];

                if (symbol == '-')
                {
                    matrix[fRow, fCol] = '-';
                    fRow = newRow;
                    fCol = newCol;
                    matrix[fRow, fCol] = 'f';
                }
                else if (symbol == 'F')
                {
                    matrix[fRow, fCol] = '-';
                    matrix[newRow, newCol] = 'f';
                    hasWon = true;
                    break;
                }
                else if (symbol == 'B')
                {
                    switch (direction)
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

                    if (newRow < 0) newRow = matrixSize - 1;
                    if (newRow == matrixSize) newRow = 0;
                    if (newCol < 0) newCol = matrixSize - 1;
                    if (newCol == matrixSize) newCol = 0;

                    char symbolNext = matrix[newRow, newCol];


                    if (symbolNext == '-')
                    {
                        matrix[fRow, fCol] = '-';
                        fRow = newRow;
                        fCol = newCol;
                        matrix[fRow, fCol] = 'f';
                    }
                    else if (symbolNext == 'F')
                    {
                        matrix[fRow, fCol] = '-';
                        matrix[newRow, newCol] = 'f';
                        hasWon = true;
                        break;
                    }

                }




            }
            if (hasWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }


        }
    }
}
