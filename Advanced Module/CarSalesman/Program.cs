using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 2)
                {
                    Engine engine = new Engine(input[0], int.Parse(input[1]));
                    engines.Add(engine.Model, engine);
                }
                else if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out _))
                    {
                        Engine engine = new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]));
                        engines.Add(engine.Model, engine);
                    }
                    else
                    {
                        Engine engine = new Engine(input[0], int.Parse(input[1]), input[2]);
                        engines.Add(engine.Model, engine);
                    }
                }
                else
                {
                    Engine engine = new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]), input[3]);
                    engines.Add(engine.Model, engine);
                }
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 2)
                {
                    Car car = new Car(input[0], engines[input[1]]);
                    carList.Add(car);
                }
                else if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out _))
                    {
                        Car car = new Car(input[0], engines[input[1]], int.Parse(input[2]));
                        carList.Add(car);
                    }
                    else
                    {
                        Car car = new Car(input[0], engines[input[1]], input[2]);
                        carList.Add(car);
                    }
                }
                else
                {
                    Car car = new Car(input[0], engines[input[1]], int.Parse(input[2]), input[3]);
                    carList.Add(car);
                }
            }


            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }


        }
    }
}
