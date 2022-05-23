using System;

namespace cinema_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int counter = 0;
            string numToPrint = string.Empty;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d)
                            {
                                int x = a * b + c * d;

                                if (x == m)
                                {
                                    Console.Write($"{a}{b}{c}{d} ");
                                    counter++;

                                    if (counter == 4)
                                    {
                                        numToPrint = Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c) + Convert.ToString(d);
                                    }
                                    
                                }
                                
                            }
                        }
                    }
                }
            }
            if (counter >= 4)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {numToPrint}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"No!");
            }
        }
    }
}
