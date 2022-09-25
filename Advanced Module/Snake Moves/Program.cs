using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[] snake = Console.ReadLine().ToCharArray();
            List<char> snakeList = new List<char>();
            while (snakeList.Count < sizes[0] * sizes[1])
            {
                snakeList.AddRange(snake);
            }

            char[,] matrix = new char[sizes[0], sizes[1]];
            int countFiller = 0;
            for (int i = 0; i < sizes[0]; i++)
            {
                if (i % 2 == 0)
                {
                    for (int z = 0; z < sizes[1]; z++)
                    {
                        matrix[i, z] = snakeList[countFiller];
                        countFiller++;
                    }
                }
                else if (i % 2 != 0)
                {
                    for (int z = sizes[1] - 1; z >= 0; z--)
                    {
                        matrix[i, z] = snakeList[countFiller];
                        countFiller++;
                    }
                }
            }

            for (int i = 0; i < sizes[0]; i++)
            {
                for (int z = 0; z < sizes[1]; z++)
                {
                    Console.Write(matrix[i, z]);
                }
                Console.WriteLine();
            }
        }
    }
}
