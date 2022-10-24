using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Speed_Racing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsump)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsump;
            TravelledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double kms)
        {
            double fuelNeeded = FuelConsumptionPerKilometer * kms;
            if (this.FuelAmount >= fuelNeeded)
            {
                this.FuelAmount -= fuelNeeded;
                this.TravelledDistance += kms;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
