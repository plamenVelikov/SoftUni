using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numGroups = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();
            for (int i = numGroups.Count - 1; i >= 0; i--)
            {
                var tempList = numGroups[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(tempList);
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
