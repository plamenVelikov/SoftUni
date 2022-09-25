using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int z = 0; z < input.Length; z++)
                {
                    set.Add(input[z]);
                }
            }

            Console.WriteLine(string.Join(" ", set.OrderBy(x => x)));
        }
    }
}
