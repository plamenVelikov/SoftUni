using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
            }

            string[] input = Console.ReadLine().Split();
            while (input[0].ToLower() != "end")
            {

                
                switch (input[0].ToLower())
                {
                    case "add":
                        stack.Push(int.Parse(input[1]));
                        stack.Push(int.Parse(input[2]));
                            break;
                    case "remove":
                        int digitsToRemove = int.Parse(input[1]);
                        if (stack.Count >= digitsToRemove) 
                        {
                            for (int i = 0; i < digitsToRemove; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split();
            }
            int sum = 0;
            for (int i = stack.Count; i > 0; i--)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
