using System;

namespace Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
