using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrOdd = new int[n];
            int[] arrEven = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    arrOdd[i] = input[0];
                    arrEven[i] = input[1];
                }
                else
                {
                    arrOdd[i] = input[1];
                    arrEven[i] = input[0];
                }
            }
            foreach (var num in arrOdd)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            foreach (var num in arrEven)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
