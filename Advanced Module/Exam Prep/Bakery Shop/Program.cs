using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] firstArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] secondArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Dictionary<string, int> products = new Dictionary<string, int>();
            Queue<double> water = new Queue<double>();
            foreach (var waterValue in firstArr)
            {
                water.Enqueue(waterValue);
            }

            Stack<double> flour = new Stack<double>();
            foreach (var flourValue in secondArr)
            {
                flour.Push(flourValue);
            }


            while (Math.Min(water.Count, flour.Count) != 0)
            {
                //•	Croissant – consists of 50 % water and 50 % flour
                //•	Muffin – consists of 40 % water and 60 % flour
                //•	Baguette – consists of 30 % water and 70 % flour
                //•	Bagel – consists of 20 % water and 80 % flour


                double currWater = water.Peek();
                double currFlour = flour.Peek();
                double wholeMix = currWater + currFlour;
                double waterPercent = (currWater * 100) / wholeMix;

                if (waterPercent == 50)
                {
                    water.Dequeue();
                    flour.Pop();
                    if (!products.ContainsKey("Croissant"))
                    {
                        products.Add("Croissant", 1);
                    }
                    else
                    {
                        products["Croissant"]++;
                    }
                }
                else if (waterPercent == 40)
                {
                    water.Dequeue();
                    flour.Pop();
                    if (!products.ContainsKey("Muffin"))
                    {
                        products.Add("Muffin", 1);
                    }
                    else
                    {
                        products["Muffin"]++;
                    }
                }
                else if (waterPercent == 30)
                {
                    water.Dequeue();
                    flour.Pop();
                    if (!products.ContainsKey("Baguette"))
                    {
                        products.Add("Baguette", 1);
                    }
                    else
                    {
                        products["Baguette"]++;
                    }
                }
                else if (waterPercent == 20)
                {
                    water.Dequeue();
                    flour.Pop();
                    if (!products.ContainsKey("Bagel"))
                    {
                        products.Add("Bagel", 1);
                    }
                    else
                    {
                        products["Bagel"]++;
                    }
                }
                else
                {
                    double leftOutFlour = currFlour - currWater;
                    water.Dequeue();
                    flour.Pop();
                    flour.Push(leftOutFlour);
                    if (!products.ContainsKey("Croissant"))
                    {
                        products.Add("Croissant", 1);
                    }
                    else
                    {
                        products["Croissant"]++;
                    }
                }
            }

            foreach (var product in products.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            if (water.Count != 0)
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }
            else
            {
                Console.WriteLine("Water left: None");
            }

            if (flour.Count != 0)
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }

        }
    }
}
