using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<Vehicle> vehicles = new List<Vehicle>();

            while (input[0] != "End")
            {
                string typeOfVehicle = input[0];
                string model = input[1];
                string color = input[2];
                double horsePower = double.Parse(input[3]);
                Vehicle vehicle = new Vehicle();
                if (typeOfVehicle == "car")
                {
                    vehicle.Type = typeOfVehicle;
                    vehicle.Model = model;
                    vehicle.Color = color;
                    vehicle.HP = horsePower;
                }
                else
                {
                    vehicle.Type = typeOfVehicle;
                    vehicle.Model = model;
                    vehicle.Color = color;
                    vehicle.HP = horsePower;
                }
                vehicles.Add(vehicle);
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            while (true)
            {
                string inputTwo = Console.ReadLine();
                if (inputTwo == "Close the Catalogue")
                {
                    double carHPAvg = 0.00;
                    double truckHPAvg = 0.00;
                    if (vehicles.Any(x => x.Type == "car"))
                    {
                        List<Vehicle> carList = vehicles.FindAll(x => x.Type == "car");
                        carHPAvg = carList.Average(x => x.HP);

                    }
                    if (vehicles.Any(x => x.Type == "truck"))
                    {
                        List<Vehicle> truckList = vehicles.FindAll(x => x.Type == "truck");
                        truckHPAvg = truckList.Average(x => x.HP);
                    }
                    Console.WriteLine($"Cars have average horsepower of: {carHPAvg:f2}.");
                    Console.WriteLine($"Trucks have average horsepower of: {truckHPAvg:f2}.");
                    return;
                }

                Vehicle currVehicle = vehicles.Find(x => x.Model == inputTwo);
                string type = currVehicle.Type;
                Console.WriteLine($"Type: {char.ToUpper(type[0]) + type.Substring(1)}");
                Console.WriteLine($"Model: {currVehicle.Model}");
                Console.WriteLine($"Color: {currVehicle.Color}");
                Console.WriteLine($"Horsepower: {currVehicle.HP}");
            }
        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HP { get; set; }
    }
}
