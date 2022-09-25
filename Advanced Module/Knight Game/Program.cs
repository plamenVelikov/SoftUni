using System;
using System.Numerics;

namespace Knight_Game
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int knightsRemoved = 0;


            for (int i = 0; i < size; i++)
            {
                char[] line = Console.ReadLine().ToCharArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            for (int threatLevel = 8; threatLevel > 0; threatLevel--)
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int knightThreat = 0;
                            if (IsThereThreat(row + 2, col - 1, matrix)) knightThreat++;
                            if (IsThereThreat(row + 2, col + 1, matrix)) knightThreat++;
                            if (IsThereThreat(row - 2, col - 1, matrix)) knightThreat++;
                            if (IsThereThreat(row - 2, col + 1, matrix)) knightThreat++;
                            if (IsThereThreat(row - 1, col + 2, matrix)) knightThreat++;
                            if (IsThereThreat(row + 1, col + 2, matrix)) knightThreat++;
                            if (IsThereThreat(row - 1, col - 2, matrix)) knightThreat++;
                            if (IsThereThreat(row + 1, col - 2, matrix)) knightThreat++;
                            if (knightThreat == threatLevel)
                            {
                                matrix[row, col] = '0';
                                knightsRemoved++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(knightsRemoved);
        }
 
        public static bool IsThereThreat(int row, int col, char[,] matrix)
        {
            int size = matrix.GetLength(0);
            if (row < 0 || row >= size || col < 0 || col >= size)
                return false;
            if (matrix[row, col] != 'K')
            {
                return false;
            }
            return true;
        }
    }
}
