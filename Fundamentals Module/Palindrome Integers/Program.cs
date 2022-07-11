using System;

namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);

            while (true)
            {
                Result(number);
                input = Console.ReadLine();
                if (input == "END")
                {
                    return;
                }
                number = int.Parse(input);
            }
        }
        static void Result(int number)
        {
            bool isItPalindrome = false;
            int numLength = Convert.ToString(number).Length;
            string numToString = number.ToString();
            string firstHalf = String.Empty;
            string secondHalf = String.Empty;

            for (int i = 0; i < numLength / 2; i++)
            {
                firstHalf += numToString[i].ToString();
            }
            if (numLength % 2 == 0)
            {
                for (int i = numLength - 1; i >= numLength / 2; i--)
                {
                    secondHalf += numToString[i].ToString();
                }
            }
            else
            {
                for (int i = numLength - 1; i > numLength / 2; i--)
                {
                    secondHalf += numToString[i].ToString();
                }
            }

            if (firstHalf == secondHalf)
            {
                isItPalindrome = true;
            }

            if (isItPalindrome)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}