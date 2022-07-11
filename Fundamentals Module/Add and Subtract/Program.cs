using System;

namespace Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            
            Console.WriteLine(SubtractSum(AddFirstTwo(num1, num2), num3));
        }

        private static int SubtractSum(int a, int b) => a - b;

        private static int AddFirstTwo(int a, int b) => a + b;
    }
}
