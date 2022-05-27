using System;

namespace Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullText = "";
            for (int i = 0; i < 3; i++)
            {
                char character = char.Parse(Console.ReadLine());
                fullText += character;
            }
            char[] charArr = fullText.ToCharArray();
            Array.Reverse(charArr);
            foreach (var value in charArr)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
