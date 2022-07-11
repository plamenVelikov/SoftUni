using System;

namespace Computer_Store___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            decimal totalPriceBeforeTax = 0;
            decimal totalTax = 0;

            string input = Console.ReadLine();
            while (decimal.TryParse(input, out _))
            {
                if (decimal.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPriceBeforeTax += decimal.Parse(input);
                    totalTax += decimal.Parse(input) * (decimal)0.2;
                }
                input = Console.ReadLine();
            }

            decimal totalPrice = totalTax + totalPriceBeforeTax;
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");

                return;
            }
            if (input == "special")
            {
                totalPrice *= (decimal)0.90;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceBeforeTax:f2}$");
            Console.WriteLine($"Taxes: {totalTax:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}
