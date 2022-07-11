using System;
using System.Linq;

namespace Array_Modifier___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            string[] commands = Console.ReadLine().Split(' ');
            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "swap":
                        Swap(numbers, long.Parse(commands[1]), long.Parse(commands[2]));
                        break;
                    case "multiply":
                        Multiply(numbers, long.Parse(commands[1]), long.Parse(commands[2]));
                        break;
                    case "decrease":
                        Decrease(numbers);
                        break;
                    default:
                        break;
                }
                commands = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        static void Decrease(long[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= 1;
            }
        }

        static void Multiply(long[] numbers, long index1, long index2)
        {
            numbers[index1] = numbers[index1] * numbers[index2];
        }

        static void Swap(long[] numbers, long index1, long index2)
        {
            long temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }
    }
}
