using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int rackCap = int.Parse(Console.ReadLine());
            int sumValue = 0;
            int racksUsed = 0;

            if (!stack.Any())
            {
                Console.WriteLine("0");
            }


            while (stack.Count > 0)
            {
                if (sumValue == 0)
                {
                    racksUsed += 1;
                }

                if (sumValue + stack.Peek() < rackCap)
                {

                    sumValue += stack.Pop();
                }
                else if (sumValue + stack.Peek() == rackCap)
                {
                    stack.Pop();
                    sumValue = 0;
                }
                else
                {
                    sumValue = 0;
                }
            }
            Console.WriteLine(racksUsed);

        }
    }
}
