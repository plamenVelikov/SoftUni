using System;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            switch (action)
            {
                case "add":
                    Add(firstNum, secondNum);
                    break;
                case "multiply":
                    Multiply(firstNum, secondNum);
                    break;
                case "subtract":
                    Subract(firstNum, secondNum);
                    break;
                case "divide":
                    Divide(firstNum, secondNum);
                    break;
                default:
                    break;
            }
        }

        static void Add(int f, int s)
        {

            Console.WriteLine(f + s);
        }
        static void Multiply(int f, int s)
        {

            Console.WriteLine(f * s);
        }
        static void Subract(int f, int s)
        {

            Console.WriteLine(f - s);
        }
        static void Divide(int f, int s)
        {

            Console.WriteLine(f / s);
        }
    }
}
