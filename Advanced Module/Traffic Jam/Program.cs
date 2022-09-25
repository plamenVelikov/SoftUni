using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsThatCanPass = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string command = Console.ReadLine();
            int carsPassed = 0;
            while (command != "end")
            {
                if (command != "green")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    if (queue.Count < carsThatCanPass)
                    {
                        int carsWaiting = queue.Count;
                        for (int i = 0; i < carsWaiting; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                        }
                        carsPassed += carsWaiting;
                    }
                    else
                    {
                        for (int i = 0; i < carsThatCanPass; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                        }
                        carsPassed += carsThatCanPass;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
