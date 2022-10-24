using System;
using System.Collections.Generic;
using System.Linq;

namespace Energy_Drinks___Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int currCaffeineState = 0;
            //max caffeine is 300
            Stack<int> milligrams = new Stack<int>();

            foreach (var milligram in firstArr)
            {
                milligrams.Push(milligram);
            }

            Queue<int> drinks = new Queue<int>();
            foreach (var drink in secondArr)
            {
                drinks.Enqueue(drink);
            }


            while (Math.Min(milligrams.Count, drinks.Count) > 0)
            {
                int currMlgrms = milligrams.Peek();
                int currDrinks = drinks.Peek();
                int caffeine = currMlgrms * currDrinks;

                if (caffeine + currCaffeineState <= 300)
                {
                    currCaffeineState += caffeine;
                    milligrams.Pop();
                    drinks.Dequeue();
                }
                else
                {
                    if (currCaffeineState < 30)
                    {
                        currCaffeineState = 0;
                    }
                    else
                    {
                        currCaffeineState -= 30;
                    }

                    milligrams.Pop();
                    drinks.Enqueue(drinks.Dequeue());
                }
            }
            if (drinks.Count != 0)
            {
                Console.WriteLine($"Drinks left: {string.Join(", ", drinks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {currCaffeineState} mg caffeine.");

        }
    }
}
