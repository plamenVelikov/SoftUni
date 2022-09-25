using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int numPasses = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(kids);
            int numPassesCount = 1;
            while (queue.Count > 1)
            {
                string kidWithPotato = queue.Dequeue();
                if (numPassesCount != numPasses)
                {
                    queue.Enqueue(kidWithPotato);
                    numPassesCount++;
                }
                else
                {
                    Console.WriteLine($"Removed {kidWithPotato}");
                    numPassesCount = 1;
                }
                
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
