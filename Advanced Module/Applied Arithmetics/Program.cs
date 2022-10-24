using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> ender = s => s != "end";

            //•	"add"->add 1 to each number
            //•	"multiply"->multiply each number by 2
            //•	"subtract"->subtract 1 from each number
            //•	"print"->print the collection
            Action<List<int>> add = nums =>
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i]++;
                }
            };

            Action<List<int>> multiply = nums =>
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i] *= 2;
                }
            };

            Action<List<int>> subtract = nums =>
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i]--;
                }
            };
            Action<List<int>> print = nums =>
            {
                Console.WriteLine(String.Join(" ", nums));
            };
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (ender(command))
            {
                switch (command)
                {
                    case "add":
                        add(list);
                        break;
                    case "multiply":
                        multiply(list);
                        break;
                    case "subtract":
                        subtract(list);
                        break;
                    case "print":
                        print(list);
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
