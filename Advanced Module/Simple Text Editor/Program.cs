using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string text = String.Empty;
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                switch (commands[0])
                {
                    case "1":
                        stack.Push(text);
                        text = text + commands[1];
                        break;
                    case "2":
                        stack.Push(text);
                        text = text.Remove(text.Length - int.Parse(commands[1]));
                        break;
                    case "3":
                        Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                        break;
                    case "4":
                        text = stack.Pop();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
