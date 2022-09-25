using System;
using System.Linq;

namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            long[][] matrix = new long[size][];
            matrix[0] = new long[3] { 0, 1, 0 };

            //  0 1 0
            // 0 1 1 0
            //0 1 2 1 0

            for (int i = 1; i < size; i++)
            {
                matrix[i] = new long[matrix[i - 1].Length + 1];
                for (int z = 0; z < matrix[i].Length - 1; z++)
                {
                    if (z == 0)
                    {
                        matrix[i][z] = 0;
                    }
                    else
                    {
                        matrix[i][z] = matrix[i - 1][z] + matrix[i - 1][z - 1];
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int b = 1; b < matrix[i].Length - 1; b++)
                {
                    Console.Write($"{matrix[i][b]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
