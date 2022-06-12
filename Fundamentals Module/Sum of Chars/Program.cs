using System;

namespace Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char firstChar = (char)('a' + i);
                for (int j = 0; j < n; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (int l = 0; l < n; l++)
                    {
                        char thirdChar = (char)('a' + l);
                        Console.Write($"{firstChar}{secondChar}{thirdChar}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
