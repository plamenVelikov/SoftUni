using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> que = new Queue<int>(orders);

            if (que.Any())
            {
                Console.WriteLine($"{que.Max()}");
            }
            while (que.Count > 0)
            {
                int currOrder = que.Peek();
                if (food - currOrder >= 0)
                {
                    food -= currOrder;
                    que.Dequeue();

                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", que)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
