using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> ClrByItemsWithCount = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] items = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!ClrByItemsWithCount.ContainsKey(color))
                {
                    ClrByItemsWithCount.Add(color, new Dictionary<string, int>());
                    for (int z = 0; z < items.Length; z++)
                    {
                        if (!ClrByItemsWithCount[color].ContainsKey(items[z]))
                        {
                            ClrByItemsWithCount[color].Add(items[z], 1);
                        }
                        else
                        {
                            ClrByItemsWithCount[color][items[z]]++;
                        }
                        
                    }
                }
                else
                {
                    for (int x = 0; x < items.Length; x++)
                    {
                        if (!ClrByItemsWithCount[color].ContainsKey(items[x]))
                        {
                            ClrByItemsWithCount[color].Add(items[x], 1);
                        }
                        else
                        {
                            ClrByItemsWithCount[color][items[x]]++;
                        }
                    }
                }

            }

            string[] itemToLookUp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in ClrByItemsWithCount)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var itemNCount in color.Value)
                {
                    if (color.Key == itemToLookUp[0] && itemNCount.Key == itemToLookUp[1])
                    {
                        Console.WriteLine($"* {itemNCount.Key} - {itemNCount.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {itemNCount.Key} - {itemNCount.Value}");
                    }
                }
            }
        }
    }
}
