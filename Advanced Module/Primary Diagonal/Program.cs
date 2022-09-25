using System;
using System.Linq;

namespace Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeSqMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeSqMatrix, sizeSqMatrix];

            for (int i = 0; i < sizeSqMatrix; i++)
            {
                int[] inputPerRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < sizeSqMatrix; j++)
                {
                    matrix[i, j] = inputPerRow[j];
                }
            }

            int sum = 0;

            for (int i = 0; i < sizeSqMatrix; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
