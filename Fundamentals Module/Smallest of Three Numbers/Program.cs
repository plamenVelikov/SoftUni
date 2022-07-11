using System;

namespace Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = new int[3];

            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = int.Parse(Console.ReadLine());
            }
            PrintLowestNumb(numbs);
        }

        static void PrintLowestNumb(int[] numbs)
        {
            Console.WriteLine(Math.Min(numbs[0], Math.Min(numbs[1], numbs[2])));
        }
    }
}
