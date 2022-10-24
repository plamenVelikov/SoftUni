using System;
using System.Collections.Generic;

namespace Speed_Racing
{
    public class SpeedRacing
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> carList = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(inputData[0], double.Parse(inputData[1]), double.Parse(inputData[2]));
                carList.Add(inputData[0], car);
            }
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            while (commands[0] != "End")
            {
                carList[commands[1]].Drive(double.Parse(commands[2]));

                commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var car in carList.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
