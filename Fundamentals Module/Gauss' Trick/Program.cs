using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int origCount = numbers.Count;
            for (int i = 0; i < origCount / 2; i++)
            {
                result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }
            if (origCount % 2 != 0)
            {
                result.Add(numbers[origCount / 2]);
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}