using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] tireInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<Tire[]> tires = new List<Tire[]>();
            while (tireInput[0] != "No")
            {
                tires.Add(new Tire[4]
                {
                new Tire(int.Parse(tireInput[0]), double.Parse(tireInput[1])),
                new Tire(int.Parse(tireInput[2]), double.Parse(tireInput[3])),
                new Tire(int.Parse(tireInput[4]), double.Parse(tireInput[5])),
                new Tire(int.Parse(tireInput[6]), double.Parse(tireInput[7]))
                });
                tireInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string[] engineInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<Engine> engines = new List<Engine>();
            while (engineInput[0] != "Engines")
            {
                Engine engine = new Engine(int.Parse(engineInput[0]), double.Parse(engineInput[1]));
                engines.Add(engine);

                engineInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            //string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            List<Car> carList = new List<Car>();
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "Show")
            {
                string make = input[0];
                string model = input[1];

                int year = int.Parse(input[2]);

                double fuelQuantity = double.Parse(input[3]);
                double fuelConsumption = double.Parse(input[4]);

                int engineIndex = int.Parse(input[5]);
                int tiresIndex = int.Parse(input[6]);

                carList.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));

                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            List<Car> specialCars = new List<Car>();
            foreach (var car in carList)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330)
                {
                    double sumTirePressure = 0;
                    foreach (var tire in car.Tires)
                    {
                        sumTirePressure += tire.Pressure;
                    }
                    if (sumTirePressure >= 9 && sumTirePressure <= 10)
                    {
                        specialCars.Add(car);
                    }
                }
            }
            foreach (var car in specialCars)
            {
                car.Drive(20);
            }
            foreach (var car in specialCars)
            {
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
