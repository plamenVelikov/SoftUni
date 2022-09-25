using System;
using System.Collections.Generic;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<int> stack = new Stack<int>();

            foreach (var item in input)
            {
                if (int.TryParse(item, out _))
                {
                    stack.Push(int.Parse(item));
                }
            }
            int numToRemove = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "-")
                {
                    numToRemove += int.Parse(input[i + 1]);
                }
            }
            int stackSum = 0;
            while (stack.Count > 0)
            {
                stackSum += stack.Pop();
            }
            numToRemove *= 2;
            Console.WriteLine(stackSum - numToRemove);
        }
    }
}
