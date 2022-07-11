using System;
using System.Collections.Generic;

namespace List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            list.Sort();
            int counter = 1;
            foreach (var product in list)
            {
                Console.WriteLine($"{counter}.{product}");
                counter++;
            }
        }
    }
}
