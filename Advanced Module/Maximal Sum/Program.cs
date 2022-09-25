using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            List<int> bestSubMatrix = new List<int>();
            List<int> currSubMatrix = new List<int>();
            int bestMatrixSum = int.MinValue;

            for (int i = 0; i < sizes[0]; i++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            for (int iMover = 0; iMover < sizes[0] - 2; iMover++)
            {
                for (int zMover = 0; zMover < sizes[1] - 2; zMover++)
                {
                    for (int i = 0 + iMover; i < 3 + iMover; i++)
                    {
                        for (int z = 0 + zMover; z < 3 + zMover; z++)
                        {
                            currSubMatrix.Add(matrix[i, z]);
                        }
                    }

                    if (currSubMatrix.Sum() > bestMatrixSum)
                    {
                        bestSubMatrix.Clear();
                        bestMatrixSum = currSubMatrix.Sum();
                        bestSubMatrix.InsertRange(0, currSubMatrix);
                        currSubMatrix.Clear();
                    }
                    else
                    {
                        currSubMatrix.Clear();
                    }
                }
            }
            Console.WriteLine($"Sum = {bestSubMatrix.Sum()}");
            int counterLineChange = 0;
            for (int i = 0; i < bestSubMatrix.Count; i++)
            {
                Console.Write($"{bestSubMatrix[i]} ");
                counterLineChange++;
                if (counterLineChange % 3 == 0 && i != bestSubMatrix.Count - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
