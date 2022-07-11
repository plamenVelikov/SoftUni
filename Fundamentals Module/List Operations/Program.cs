using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) > numbers.Count - 1 || int.Parse(command[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) > numbers.Count - 1 || int.Parse(command[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(command[1]));
                        }
                        break;
                    case "Shift":
                        Shifting(numbers, command[1], int.Parse(command[2]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }

        static void Shifting(List<int> numbers, string direction, int count)
        {
            if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }
    }
}
