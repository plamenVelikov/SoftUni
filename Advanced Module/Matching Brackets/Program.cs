﻿using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                if (input[i] == ')')
                {
                    int numStart = stack.Pop();
                    Console.WriteLine(input.Substring(numStart, i - numStart + 1));
                }
            }
        }
    }
}
