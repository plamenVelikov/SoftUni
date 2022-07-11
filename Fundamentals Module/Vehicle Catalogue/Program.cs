using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string[] inputProps = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries);
            while (inputProps[0] != "end")
            {
                if (inputProps[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = inputProps[1];
                    car.Model = inputProps[2];
                    car.HP = int.Parse(inputProps[3]);

                    catalog.Cars.Add(car);
                }
                else if (inputProps[0] == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = inputProps[1];
                    truck.Model = inputProps[2];
                    truck.Weight = int.Parse(inputProps[3]);

                    catalog.Trucks.Add(truck);
                }
                inputProps = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries);
            }

            if (catalog.Cars.Count > 0)
            {
                List<Car> orderedCars = catalog.Cars.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Cars: ");
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HP}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Trucks: ");
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
}
