using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> removedNums = new List<int>();

            int index = int.Parse(Console.ReadLine());

            while (numbers.Count != 0)
            {
                int indexNum = 0;
                if (index < 0)
                {
                    removedNums.Add(numbers[0]);
                    indexNum = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (index > numbers.Count - 1)
                {
                    removedNums.Add(numbers[numbers.Count - 1]);
                    indexNum = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    indexNum = numbers[index];
                    removedNums.Add(numbers[index]);
                    numbers.RemoveAt(index);
                    if (numbers.Count == 0)
                    {
                        break;
                    }
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= indexNum)
                    {
                        numbers[i] += indexNum;
                    }
                    else if (numbers[i] > indexNum)
                    {
                        numbers[i] -= indexNum;
                    }
                }
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(removedNums.Sum());
        }
    }
}
