using System;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] inputRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = inputRow[j];
                }
            }


            int primDiagSum = 0;
            int secDiagSum = 0;

            for (int i = 0; i < size; i++)
            {
                primDiagSum += matrix[i, i];
            }

            for (int i = 0; i < size; i++)
            {
                secDiagSum += matrix[i, size - 1 - i];
            }

            Console.WriteLine(Math.Max(primDiagSum, secDiagSum) - Math.Min(primDiagSum, secDiagSum));
        }
    }
}
