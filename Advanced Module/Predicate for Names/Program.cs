using System;

namespace Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int letters = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> isItCorrectLength = name => name.Length <= letters;

            for (int i = 0; i < names.Length; i++)
            {
                if (isItCorrectLength(names[i]))
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
