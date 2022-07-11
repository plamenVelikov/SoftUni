using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_for_the_Win___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int shotCount = 0;
            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "End")
            {
                int index = int.Parse(command[0]);
                if (index >= 0 && index < numbers.Count)
                {
                    if (numbers[index] >= 0)
                    {
                        int tempNum = numbers[index];
                        shotCount++;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > tempNum && numbers[i] != -1)
                            {
                                numbers[i] -= tempNum;
                            }
                            else if (numbers[i] <= tempNum && numbers[i] != -1)
                            {
                                numbers[i] += tempNum;
                            }
                        }
                        numbers[index] = -1;
                    }
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine($"Shot targets: {shotCount} -> {string.Join(' ', numbers)}");
        }
    }
}
