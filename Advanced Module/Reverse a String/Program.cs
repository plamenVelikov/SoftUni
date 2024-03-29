﻿using System;
using System.Collections.Generic;

namespace Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char item in input)
            {
                stack.Push(item);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
