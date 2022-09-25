using System;
using System.Collections.Generic;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> que = new Queue<string>();
            while (input != "End")
            {
                if (input != "Paid")
                {
                    que.Enqueue(input);
                }
                else
                {
                    while (que.Count > 0)
                    {
                        Console.WriteLine(que.Dequeue());
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{que.Count} people remaining.");
        }
    }
}
