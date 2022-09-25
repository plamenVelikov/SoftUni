using System;
using System.Linq;

namespace Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            input = input.OrderByDescending(x => x).ToArray();
            if (input.Length < 3)
            {
                Console.WriteLine(string.Join(' ', input));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
