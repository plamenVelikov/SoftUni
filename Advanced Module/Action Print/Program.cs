using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = s => Console.WriteLine(s);
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            input.ForEach(print);
        }
    }
}
