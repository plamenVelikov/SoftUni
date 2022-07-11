using System;

namespace Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(ReturnString(input, n));
        }

        static string ReturnString(string input, int n)
        {
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
