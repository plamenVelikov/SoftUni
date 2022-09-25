using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> peopleNums = new Dictionary<string, int[]>();
            Dictionary<string, List<string>> peopleFollowers = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "Statistics")
            {
                switch (input[1])
                {
                    case "joined":
                        if (!peopleNums.ContainsKey(input[0]))
                        {
                            peopleNums.Add(input[0], new int[2]);
                            peopleFollowers.Add(input[0], new List<string>());
                        }
                        break;
                    case "followed":
                        if (peopleNums.ContainsKey(input[0]) && peopleNums.ContainsKey(input[2]) && input[0] != input[2])
                        {
                            if (!peopleFollowers[input[2]].Contains(input[0]))
                            {
                                peopleNums[input[0]][1]++;
                                peopleNums[input[2]][0]++;
                                peopleFollowers[input[2]].Add(input[0]);
                            }
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split();
            }

            Console.WriteLine($"The V-Logger has a total of {peopleNums.Count} vloggers in its logs.");

            int counter = 1;
            foreach (var item in peopleNums.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]))
            {
                Console.WriteLine($"{counter}. {item.Key} : {item.Value[0]} followers, {item.Value[1]} following");
                if (peopleFollowers[item.Key].Count != 0 && counter == 1)
                {
                    foreach (var z in peopleFollowers[item.Key].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {z}");
                    }
                }
                counter++;
            }
        }
    }
}
