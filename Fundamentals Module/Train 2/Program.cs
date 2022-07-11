using System;
using System.Collections.Generic;
using System.Linq;

namespace Train_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxCap = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else if (int.TryParse(command[0], out _))
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(command[0]) <= maxCap)
                        {
                            wagons[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
