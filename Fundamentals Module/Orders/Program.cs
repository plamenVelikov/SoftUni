using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 1; i <= orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                double days = double.Parse(Console.ReadLine());
                double capsulesCount = double.Parse(Console.ReadLine());

                double priceOfCoffee = days * capsulesCount * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${priceOfCoffee:f2}");
                totalPrice += priceOfCoffee;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
