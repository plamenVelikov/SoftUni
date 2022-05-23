using System;

namespace _01._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int UpFirst = int.Parse(Console.ReadLine());
            int UpSecond = int.Parse(Console.ReadLine());
            int UpThird = int.Parse(Console.ReadLine());

            for (int i = 2; i <= UpFirst; i += 2)
            {
                for (int j = 2; j <= UpSecond; j++)
                {
                    if (j == 2 || j == 3 || j == 5 || j == 7)
                    {
                        for (int r = 2; r <= UpThird; r += 2)
                        {
                            Console.WriteLine($"{i} {j} {r}");
                        }
                    }
                }
            }


        }
    }
}