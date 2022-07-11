using System;

namespace Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int newIndex = rnd.Next(0, input.Length);
                string toSwap = input[i];
                input[i] = input[newIndex];
                input[newIndex] = toSwap;
            }
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
