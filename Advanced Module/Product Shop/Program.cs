using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> kvp = new Dictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "Revision")
            {
                if (!kvp.ContainsKey(input[0]))
                {
                    kvp.Add(input[0], new Dictionary<string, double>());
                    kvp[input[0]].Add(input[1], double.Parse(input[2]));
                }
                else
                {
                    kvp[input[0]].Add(input[1], double.Parse(input[2]));
                }
                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var shop in kvp.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var prodNPrice in shop.Value)
                {
                    Console.WriteLine($"Product: {prodNPrice.Key}, Price: {prodNPrice.Value}");
                }
            }
        }
    }
}
