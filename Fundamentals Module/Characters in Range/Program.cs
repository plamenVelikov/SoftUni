using System;

namespace Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());
            PrintSequence(charOne, charTwo);

        }

        private static void PrintSequence(char charOne, char charTwo)
        {
            int start = Math.Min(charOne, charTwo);
            int end = Math.Max(charOne, charTwo);

            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
