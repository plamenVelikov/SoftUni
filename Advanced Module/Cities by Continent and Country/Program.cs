using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> nestedDict = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < x; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!nestedDict.ContainsKey(input[0]))
                {
                    nestedDict.Add(input[0], new Dictionary<string, List<string>>());
                    nestedDict[input[0]].Add(input[1], new List<string>());
                    nestedDict[input[0]][input[1]].Add(input[2]);
                }
                else if (nestedDict.ContainsKey(input[0]))
                {
                    if (!nestedDict[input[0]].ContainsKey(input[1]))
                    {
                        nestedDict[input[0]].Add(input[1], new List<string>());
                        nestedDict[input[0]][input[1]].Add(input[2]);
                    }
                    else
                    {
                        nestedDict[input[0]][input[1]].Add(input[2]);
                    }
                }
            }


            foreach (var continent in nestedDict)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var cntryAndCaps in continent.Value)
                {
                    Console.WriteLine($"  {cntryAndCaps.Key} -> {string.Join(", ", cntryAndCaps.Value)}");
                }
            }
        }
    }
}
