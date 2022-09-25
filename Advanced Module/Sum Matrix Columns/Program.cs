using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int i = 0; i < size[0]; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int z = 0; z < size[1]; z++)
                {
                    matrix[i, z] = input[z];
                }
            }


            for (int i = 0; i < size[1]; i++)
            {
                int sum = 0;
                for (int z = 0; z < size[0]; z++)
                {
                    sum += matrix[z, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
