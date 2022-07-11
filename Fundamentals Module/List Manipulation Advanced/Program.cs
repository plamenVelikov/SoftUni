using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            bool isListModified = false;
            while (command[0] != "end")
            {
                if (command[0] == "Add" || command[0] == "Remove" || command[0] == "RemoveAt" || command[0] == "Insert")
                {
                    isListModified = true;
                }
                switch (command[0])
                {
                    case "Add":
                        nums.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        nums.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        nums.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Contains":
                        PrintContains(nums, command);
                        break;
                    case "PrintEven":
                    case "PrintOdd":
                        PrintEvenOrOdd(nums, command[0]);
                        break;
                    case "GetSum":
                        Console.WriteLine(nums.Sum());
                        break;
                    case "Filter":
                        Filtration(nums, command[1], int.Parse(command[2]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            if (isListModified)
            {
                Console.WriteLine(string.Join(' ', nums));
            }


        }

        private static void Filtration(List<int> nums, string com1, int com2)
        {
            switch (com1)
            {
                case ">":
                    foreach (var elem in nums)
                    {
                        if (elem > com2)
                        {
                            Console.Write($"{elem} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case "<":
                    foreach (var elem in nums)
                    {
                        if (elem < com2)
                        {
                            Console.Write($"{elem} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">=":
                    foreach (var elem in nums)
                    {
                        if (elem >= com2)
                        {
                            Console.Write($"{elem} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case "<=":
                    foreach (var elem in nums)
                    {
                        if (elem <= com2)
                        {
                            Console.Write($"{elem} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }

        private static void PrintEvenOrOdd(List<int> nums, string com0)
        {
            if (com0 == "PrintEven")
            {
                foreach (var item in nums)
                {
                    if (item % 2 == 0)
                    {
                        Console.Write($"{item} ");
                    }
                }
                Console.WriteLine();
            }
            else if (com0 == "PrintOdd")
            {
                foreach (var item in nums)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write($"{item} ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void PrintContains(List<int> nums, string[] command)
        {
            if (nums.Contains(int.Parse(command[1])))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
