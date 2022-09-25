using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];
            List<string> currSqMatrix = new List<string>();
            int equalCellsCounter = 0;
            for (int i = 0; i < sizes[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
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
                            currSqMatrix.Add(matrix[i, z]);
                        }
                    }

                    if (currSqMatrix[0] == currSqMatrix[1] && currSqMatrix[2] == currSqMatrix[3] && currSqMatrix[1] == currSqMatrix[2])
                    {
                        equalCellsCounter++;
                    }
                    currSqMatrix.Clear();

                }
            }
            Console.WriteLine(equalCellsCounter);
        }
    }
}
