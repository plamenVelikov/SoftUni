using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Shoot":
                        Shoot(numbers, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Add":
                        Add(numbers, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Strike":
                        Strike(numbers, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join('|', numbers));
        }

        private static void Strike(List<int> numbers, int index, int radius)
        {
            if (index - radius >= 0 && index + radius < numbers.Count)
            {
                numbers.RemoveRange(index - radius, radius * 2 + 1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
        }

        private static void Add(List<int> numbers, int index, int value)
        {
            if (index >= 0 && index < numbers.Count)
            {
                numbers.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        private static void Shoot(List<int> numbers, int index, int power)
        {
            if (index >= 0 && index < numbers.Count)
            {
                numbers[index] -= power;
                if (numbers[index] <= 0)
                {
                    numbers.RemoveAt(index);
                }
            }
        }
    }
}
