using System;
using System.Collections.Generic;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            List<int> bestSubMatrix = new List<int>();
            List<int> currSubMatrix = new List<int>();

            for (int i = 0; i < sizes[0]; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            for (int iMover = 0; iMover < sizes[0] - 1; iMover++)
            {
                for (int zMover = 0; zMover < sizes[1] - 1; zMover++)
                {
                    for (int i = 0 + iMover; i < 2 + iMover; i++)
                    {
                        for (int z = 0 + zMover; z < 2 + zMover; z++)
                        {
                            currSubMatrix.Add(matrix[i, z]);
                        }
                    }

                    if (currSubMatrix.Sum() > bestSubMatrix.Sum())
                    {
                        bestSubMatrix.Clear();
                        bestSubMatrix.InsertRange(0, currSubMatrix);
                        currSubMatrix.Clear();
                    }
                    else
                    {
                        currSubMatrix.Clear();
                    }
                }
            }

            Console.WriteLine($"{bestSubMatrix[0]} {bestSubMatrix[1]}");
            Console.WriteLine($"{bestSubMatrix[2]} {bestSubMatrix[3]}");
            Console.WriteLine(bestSubMatrix.Sum());

        }
    }
}
