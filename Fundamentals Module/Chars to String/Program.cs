using System;

namespace Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string sumOfChars = char.ToString(first) + char.ToString(second) + char.ToString(third);
            Console.WriteLine($"{sumOfChars}");

        }
    }
}