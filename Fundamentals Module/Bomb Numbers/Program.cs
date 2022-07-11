using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (numbers.Contains(bombAndPower[0]))
            {
                int index = numbers.FindIndex(x => x == bombAndPower[0]);
                int destructionPointStart = index - bombAndPower[1];
                int destructionLength = bombAndPower[1] * 2 + 1;
                if (destructionPointStart < 0)
                {
                    int counter = 0;
                    while (destructionPointStart < 0)
                    {
                        destructionPointStart++;
                        counter++;
                    }
                    destructionLength -= counter;
                }
                for (int i = 0; i < destructionLength; i++)
                {
                    if (destructionPointStart <= numbers.Count - 1)
                    {
                        numbers.RemoveAt(destructionPointStart);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
