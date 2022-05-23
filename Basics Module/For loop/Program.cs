using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double oddSum = 0.00;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;

            double evenSum = 0.00;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;

            int oddCounter = 0;
            int evenCounter = 0;

            for (int position = 1; position <= num; position++)
            {
                double number = double.Parse(Console.ReadLine());

                if (position % 2 == 0)
                {
                    evenCounter++;
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddCounter++;
                    oddSum += number;
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }

            }

            //"OddSum=" + { сума на числата на нечетни позиции},
            //"OddMin=" + { минимална стойност на числата на нечетни позиции } / {“No”},
            //"OddMax=" + { максимална стойност на числата на нечетни позиции } / {“No”},
            //"EvenSum=" + { сума на числата на четни позиции },
            //"EvenMin=" + { минимална стойност на числата на четни позиции } / {“No”},
            //"EvenMax=" + { максимална стойност на числата на четни позиции } / {“No”}


            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddCounter == 0)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");

            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenCounter == 0)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }



        }
    }
}
