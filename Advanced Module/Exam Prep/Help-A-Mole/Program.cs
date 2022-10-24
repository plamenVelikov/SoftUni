using System;
using System.Collections.Generic;

namespace Help_A_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int mRow = 0;
            int mCol = 0;
            List<int> sList = new List<int>();
            int counterPts = 0;
            bool moleWon = false;
            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                    if (matrix[i, j] == 'M')
                    {
                        mRow = i;
                        mCol = j;
                    }

                    if (matrix[i, j] == 'S')
                    {
                        sList.Add(i);
                        sList.Add(j);
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {

                int newRow = mRow;
                int newCol = mCol;

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

                    if (char.IsDigit(symbol))
                    {
                        counterPts += int.Parse(symbol.ToString());
                        matrix[mRow, mCol] = '-';
                        mRow = newRow;
                        mCol = newCol;
                        matrix[mRow, mCol] = 'M';

                    }
                    else if (symbol == 'S')
                    {
                        if (newRow == sList[0] && newCol == sList[1])
                        {
                            matrix[mRow, mCol] = '-';
                            matrix[newRow, newCol] = '-';
                            mRow = sList[2];
                            mCol = sList[3];
                            matrix[mRow, mCol] = 'M';
                            counterPts -= 3;
                        }
                        else if (newRow == sList[2] && newCol == sList[3])
                        {
                            matrix[mRow, mCol] = '-';
                            matrix[newRow, newCol] = '-';
                            mRow = sList[0];
                            mCol = sList[1];
                            matrix[mRow, mCol] = 'M';
                            counterPts -= 3;

                        }
                    }
                    else if (symbol == '-')
                    {
                        matrix[mRow, mCol] = '-';
                        mRow = newRow;
                        mCol = newCol;
                        matrix[mRow, mCol] = 'M';
                    }



                }
                else
                {
                    Console.WriteLine("Don't try to escape the playing field!");
                }

                if (counterPts >= 25)
                {
                    moleWon = true;
                    break;
                }


                command = Console.ReadLine();
            }


            if (moleWon)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {counterPts} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {counterPts} points.");
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
