using System;

namespace Decrypting_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            string finalString = null;
            for (int i = 0; i < num; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int letterNum = letter + key;

                finalString += Convert.ToChar(letterNum);
            }
            Console.WriteLine(finalString);
        }
    }
}
