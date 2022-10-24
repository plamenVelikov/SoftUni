using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] cp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(cp[0], int.Parse(cp[1]), int.Parse(cp[2]), int.Parse(cp[3]),
                    cp[4],
                    double.Parse(cp[5]), int.Parse(cp[6]),
                    double.Parse(cp[7]), int.Parse(cp[8]),
                    double.Parse(cp[9]), int.Parse(cp[10]),
                    double.Parse(cp[11]), int.Parse(cp[12]));

                carList.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var item in carList.Where(c => c.Cargo.Type == "fragile" && c.Tyres.Any(c => c.Pressure < 1)))
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                foreach (var item in carList.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250))
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}
