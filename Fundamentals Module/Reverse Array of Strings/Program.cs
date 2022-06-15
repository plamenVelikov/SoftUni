using System;

namespace Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            Array.Reverse(arr);
            foreach (var word in arr)
            {
                Console.Write($"{word} ");
            }
        }
    }
}
