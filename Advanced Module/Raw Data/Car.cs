using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public  class Car
    {
        public Car(
            string model,
            int speed,
            int power,
            int weight,
            string cargoType,
            double tire1Pressure,
            int tire1Age,
            double tire2Pressure,
            int tire2Age,
            double tire3Pressure,
            int tire3Age,
            double tire4Pressure,
            int tire4Age)
        {
            Model = model;
            Engine = new Engine { Speed = speed, Power = power };
            Cargo = new Cargo { Weight = weight, Type = cargoType };
            Tyres = new Tyre[4];
            Tyres[0] = new Tyre { Pressure = tire1Pressure, Age = tire1Age };
            Tyres[1] = new Tyre { Pressure = tire2Pressure, Age = tire2Age };
            Tyres[2] = new Tyre { Pressure = tire3Pressure, Age = tire3Age };
            Tyres[3] = new Tyre { Pressure = tire4Pressure, Age = tire4Age };
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tyre[] Tyres { get; set; }

        

    }
}
