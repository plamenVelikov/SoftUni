using System;
using System.Data.Common;
using System.Linq;

namespace Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsNCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[rowsNCols[0], rowsNCols[1]];
            int sum = 0;
            for (int row = 0; row < rowsNCols[0]; row++)
            {
                int[] dataPerRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int cols = 0; cols < rowsNCols[1]; cols++)
                {
                    sum += dataPerRow[cols];
                    matrix[row, cols] = dataPerRow[cols];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);

        }
    }
}
