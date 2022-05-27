using System;

namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInputs = int.Parse(Console.ReadLine());
            string finalResult = "";
            for (int i = 0; i < numInputs; i++)
            {
                char result = ' ';
                int input = int.Parse(Console.ReadLine());
                string inputString = input.ToString();
                int numLenght = inputString.Length;
                char firstDigit = inputString[0];
                double mainDigit = char.GetNumericValue(firstDigit);
                int offset = ((int)mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset = ((int)mainDigit - 2) * 3 + 1;
                }
                int letterIndex = offset + numLenght - 1;

                if (mainDigit == 0)
                {
                    result = Convert.ToChar(32);
                }
                else
                {
                    result = Convert.ToChar(letterIndex + 97);
                }
                finalResult += result;
            }
            Console.WriteLine(finalResult);

        }
    }
}
