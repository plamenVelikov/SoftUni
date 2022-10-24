using System;
using System.Diagnostics;
using System.IO.Pipes;

namespace Super_Mario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lifePts = int.Parse(Console.ReadLine());
            int matrixRows = int.Parse(Console.ReadLine());
            if (matrixRows == 0)
            {
                return;
            }
            char[][] matrix = new char[matrixRows][];
            int[] marioCoords = new int[2];

            for (int i = 0; i < matrixRows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrixRows; j++)
                {
                    if (matrix[i][j] == 'M')
                    {
                        marioCoords[0] = i;
                        marioCoords[1] = j;
                    }
                }
            }

            while (lifePts > 0)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                matrix[int.Parse(input[1])][int.Parse(input[2])] = 'B';

                switch (input[0].ToUpper())
                {
                    case "W":
                        if (marioCoords[0] - 1 < 0)
                        {
                            lifePts--;
                            if (lifePts == 0)
                            {
                                matrix[marioCoords[0]][marioCoords[1]] = 'X';
                                Console.WriteLine($"Mario died at {marioCoords[0]};{marioCoords[1]}.");
                            }
                        }
                        else if (matrix[marioCoords[0] - 1][marioCoords[1]] == 'B')
                        {
                            if (lifePts > 3)
                            {
                                matrix[marioCoords[0] - 1][marioCoords[1]] = '-';
                                lifePts -= 2;
                                lifePts--;
                                marioCoords[0] = marioCoords[0] - 1;
                                marioCoords[1] = marioCoords[1];
                            }
                            else
                            {
                                matrix[marioCoords[0] - 1][marioCoords[1]] = 'X';
                                Console.WriteLine($"Mario died at {marioCoords[0] - 1};{marioCoords[1]}.");
                                matrix[marioCoords[0]][marioCoords[1]] = '-';
                                lifePts = 0;
                            }
                        }
                        else if (matrix[marioCoords[0] - 1][marioCoords[1]] == 'P')
                        {
                            matrix[marioCoords[0] - 1][marioCoords[1]] = '-';
                            lifePts--;
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lifePts}");
                            lifePts = 0;
                        }
                        else
                        {
                            matrix[marioCoords[0]][marioCoords[1]] = '-';
                            lifePts--;
                            marioCoords[0] = marioCoords[0] - 1;
                            marioCoords[1] = marioCoords[1];
                        }
                        break;
                    case "S":
                        if (marioCoords[0] + 1 > matrixRows - 1)
                        {
                            lifePts--;
                            if (lifePts == 0)
                            {
                                matrix[marioCoords[0]][marioCoords[1]] = 'X';
                                Console.WriteLine($"Mario died at {marioCoords[0]};{marioCoords[1]}.");
                            }
                        }
                        else if (matrix[marioCoords[0] + 1][marioCoords[1]] == 'B')
                        {
                            if (lifePts > 3)
                            {
                                matrix[marioCoords[0] + 1][marioCoords[1]] = '-';
                                lifePts -= 2;
                                lifePts--;
                                marioCoords[0] = marioCoords[0] + 1;
                                marioCoords[1] = marioCoords[1];
                            }
                            else
                            {
                                matrix[marioCoords[0] + 1][marioCoords[1]] = 'X';
                                Console.WriteLine($"Mario died at {marioCoords[0] + 1};{marioCoords[1]}.");
                                matrix[marioCoords[0]][marioCoords[1]] = '-';
                                lifePts = 0;
                            }
                        }
                        else if (matrix[marioCoords[0] + 1][marioCoords[1]] == 'P')
                        {
                            matrix[marioCoords[0] - 1][marioCoords[1]] = '-';
                            lifePts--;
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lifePts}");
                            lifePts = 0;
                        }
                        else
                        {
                            matrix[marioCoords[0]][marioCoords[1]] = '-';
                            lifePts--;
                            marioCoords[0] = marioCoords[0] + 1;
                            marioCoords[1] = marioCoords[1];
                        }
                        break;
                    case "A":
                        if (marioCoords[1] - 1 < 0)
                        {
                            lifePts--;
                            if (lifePts == 0)
                            {
                                matrix[marioCoords[0]][marioCoords[1]] = 'X';
                                Console.WriteLine($"Mario died at {marioCoords[0]};{marioCoords[1]}.");
                            }
                        }
                        else if (matrix[marioCoords[0]][marioCoords[1] - 1] == 'B')
                        {
                            if (lifePts > 3)
                            {
                                matrix[marioCoords[0]][marioCoords[1] - 1] = '-';
                                lifePts -= 2;
                                lifePts--;
                                marioCoords[0] = marioCoords[0];
                                marioCoords[1] = marioCoords[1] - 1;
                            }
                            else
                            {
                                matrix[marioCoords[0]][marioCoords[1] - 1] = 'X';
                                Console.WriteLine($"Mario died at {marioCoords[0]};{marioCoords[1] - 1}.");
                                matrix[marioCoords[0]][marioCoords[1]] = '-';
                                lifePts = 0;
                            }
                        }
                        else if (matrix[marioCoords[0]][marioCoords[1] - 1] == 'P')
                        {
                            matrix[marioCoords[0] - 1][marioCoords[1]] = '-';
                            lifePts--;
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lifePts}");
                            lifePts = 0;
                        }
                        else
                        {
                            matrix[marioCoords[0]][marioCoords[1]] = '-';
                            lifePts--;
                            marioCoords[0] = marioCoords[0];
                            marioCoords[1] = marioCoords[1] - 1;
                        }
                        break;
                    case "D":
                        if (marioCoords[1] + 1 > matrixRows - 1)
                        {
                            lifePts--;
                            if (lifePts == 0)
                            {
                                matrix[marioCoords[0]][marioCoords[1]] = 'X';
                                Console.WriteLine($"Mario died at {marioCoords[0]};{marioCoords[1]}.");
                            }
                        }
                        else if (matrix[marioCoords[0]][marioCoords[1] + 1] == 'B')
                        {
                            if (lifePts > 3)
                            {
                                matrix[marioCoords[0]][marioCoords[1] + 1] = '-';
                                lifePts -= 2;
                                lifePts--;
                                marioCoords[0] = marioCoords[0];
                                marioCoords[1] = marioCoords[1] + 1;
                            }
                            else
                            {
                                matrix[marioCoords[0]][marioCoords[1] + 1] = 'X';
                                Console.WriteLine($"Mario died at {marioCoords[0]};{marioCoords[1] + 1}.");
                                matrix[marioCoords[0]][marioCoords[1]] = '-';
                                lifePts = 0;
                            }
                        }
                        else if (matrix[marioCoords[0]][marioCoords[1] + 1] == 'P')
                        {
                            matrix[marioCoords[0] - 1][marioCoords[1]] = '-';
                            lifePts--;
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lifePts}");
                            lifePts = 0;
                        }
                        else
                        {
                            matrix[marioCoords[0]][marioCoords[1]] = '-';
                            lifePts--;
                            marioCoords[0] = marioCoords[0];
                            marioCoords[1] = marioCoords[1] + 1;
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(row);
            }

        }
    }
}
