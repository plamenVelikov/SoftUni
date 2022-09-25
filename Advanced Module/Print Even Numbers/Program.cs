using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < inputNums.Length; i++)
            {
                if (inputNums[i] % 2 == 0)
                {
                    queue.Enqueue(inputNums[i]);
                }
            }
            Console.WriteLine($"{string.Join(", ", queue)}");
        }
    }
}
