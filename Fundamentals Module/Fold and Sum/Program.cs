using System;
using System.Linq;

namespace Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] final = new int[input.Length / 2];

            int[] secondLineFirstSeg = new int[(input.Length / 4)];
            int counter = 0;

            for (int i = 0; i < input.Length / 4; i++)
            {
                secondLineFirstSeg[i] = input[i];
                counter++;
            }
            Array.Reverse(secondLineFirstSeg);
            int[] secondLineSecondSegment = new int[input.Length / 2];
            for (int z = 0; z < secondLineFirstSeg.Length; z++)
            {
                secondLineSecondSegment[z] = secondLineFirstSeg[z];
            }
            for (int j = input.Length - 1; j > input.Length - secondLineFirstSeg.Length - 1; j--)
            {
                secondLineSecondSegment[counter] = input[j];
                counter++;
            }
            for (int l = 0; l < secondLineSecondSegment.Length; l++)
            {
                final[l] = secondLineSecondSegment[l] + input[l + (input.Length / 4)];
                counter++;
            }
            Console.WriteLine(String.Join(' ', final));
        }
    }
}
