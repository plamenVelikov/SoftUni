﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "end")
            {
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
                    default:
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
