using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (var charac in input)
            {
                if (stack.Any())
                {
                    char check = stack.Peek();
                    if (check == '{' && charac == '}')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '[' && charac == ']')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '(' && charac == ')')
                    {
                        stack.Pop();
                        continue;
                    }
                }
                stack.Push(charac);
            }
            Console.WriteLine(!stack.Any() ? "YES" : "NO");
        }
    }
}
