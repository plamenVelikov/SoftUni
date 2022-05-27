using System;

namespace Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());


            double gamePrice = 0.00;
            double totalSpent = 0.00;
            while (budget > 0)
            {

                string input = Console.ReadLine();
                if (input == "Game Time")
                {
                    Console.Write($"Total spent: ${totalSpent:f2}. Remaining: ${budget:f2}");
                    return;
                }
                switch (input)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        gamePrice = 0.00;
                        Console.WriteLine("Not Found");
                        break;
                }
                if (gamePrice > 0.00)
                {
                    if (budget >= gamePrice)
                    {
                        totalSpent += gamePrice;
                        budget -= gamePrice;
                        Console.WriteLine($"Bought {input}");
                    }
                    else if (budget < gamePrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
            }
            Console.WriteLine("Out of money!");
        }
    }
}
