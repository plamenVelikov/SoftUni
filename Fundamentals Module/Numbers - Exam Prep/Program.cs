using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            double average = numbers.Average();
            numbers.RemoveAll(x => x <= average);
            numbers.Sort();
            numbers.Reverse();
            if (numbers.Count <= 5 && numbers.Count != 0)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
            else if (numbers.Count > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
