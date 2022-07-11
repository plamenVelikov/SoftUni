using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLineNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondLineNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> mergedNums = new List<int>();
            List<int> result = new List<int>();

            secondLineNums.Reverse();
            for (int i = 0; i < Math.Min(firstLineNums.Count, secondLineNums.Count); i++)
            {
                mergedNums.Add(firstLineNums[i]);
                mergedNums.Add(secondLineNums[i]);
            }

            if (firstLineNums.Count > secondLineNums.Count)
            {
                foreach (var num in mergedNums)
                {
                    if (num < Math.Max(firstLineNums[firstLineNums.Count - 2], firstLineNums[firstLineNums.Count - 1]) && num > Math.Min(firstLineNums[firstLineNums.Count - 2], firstLineNums[firstLineNums.Count - 1]))
                    {
                        result.Add(num);
                    }
                }
            }
            else if (secondLineNums.Count > firstLineNums.Count)
            {
                foreach (var num in mergedNums)
                {
                    if (num < Math.Max(secondLineNums[secondLineNums.Count - 2], secondLineNums[secondLineNums.Count - 1]) && num > Math.Min(secondLineNums[secondLineNums.Count - 2], secondLineNums[secondLineNums.Count - 1]))
                    {
                        result.Add(num);
                    }
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
