using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> list = new HashSet<string>();

            while (input.ToLower() != "party")
            {
                if (input.Length == 8)
                {

                    list.Add(input);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                if (input.Length == 8)
                {
                    list.Remove(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(list.Count);

            foreach (var item in list)
            {
                if (char.IsDigit(item[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in list)
            {
                if (char.IsLetter(item[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
