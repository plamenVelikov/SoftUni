using System;

namespace Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(CompareInt(firstNum, secondNum));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(CompareChar(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(CompareString(firstString, secondString));
                    break;

                default:
                    break;
            }
        }

        static string CompareString(string first, string second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            return second;

        }

        static char CompareChar(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }

        static int CompareInt(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }
    }
}
