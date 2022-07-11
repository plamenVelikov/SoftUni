using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLineNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondLineNumbs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Max(firstLineNums.Count, secondLineNumbs.Count); i++)
            {
                if (firstLineNums.Count > i)
                {
                    result.Add(firstLineNums[i]);
                }

                if (secondLineNumbs.Count > i)
                {
                    result.Add(secondLineNumbs[i]);
                }
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
