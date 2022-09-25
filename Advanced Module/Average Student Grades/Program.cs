using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> kvp = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!kvp.ContainsKey(input[0]))
                {
                    kvp.Add(input[0], new List<decimal>());
                    kvp[input[0]].Add(decimal.Parse(input[1]));
                }
                else
                {
                    kvp[input[0]].Add(decimal.Parse(input[1]));
                }
            }
            foreach (var item in kvp)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var dbl in item.Value)
                {
                    Console.Write($"{dbl:f2} ");
                }
                Console.Write($"(avg: {item.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
