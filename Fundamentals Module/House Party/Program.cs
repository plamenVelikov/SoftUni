using System;
using System.Collections.Generic;

namespace House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countCommands = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < countCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[2] != "not")
                {
                    if (!list.Contains(command[0]))
                    {
                        list.Add(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                }
                else
                {
                    if (list.Contains(command[0]))
                    {
                        list.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }
            foreach (var guest in list)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
