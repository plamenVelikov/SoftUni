using System;
using System.Linq;


namespace Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNums = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
            }
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine($"{arr[j]} => {roundedNums[j]}");
            }
        }
    }
}
