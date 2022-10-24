using System;
using System.Collections.Generic;
using System.Linq;

namespace Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = s => Console.WriteLine($"Sir {s}");
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            input.ForEach(print);
        }
    }
}
