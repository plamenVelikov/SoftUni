using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> que = new Queue<int>(ints);

            if (parameters[1] != 0)
            {
                for (int i = 0; i < parameters[1]; i++)
                {
                    que.Dequeue();
                }
            }

            if (que.Contains(parameters[2]))
            {
                Console.WriteLine("true");
            }
            else if (que.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(que.Min());
            }

        }
    }
}
