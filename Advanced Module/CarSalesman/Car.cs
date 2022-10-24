using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
            :this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            :this(model, engine)
        {
            Color = color;
        }
        public Car(string model, Engine engine, int weight, string color)
            :this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");
            
            if (this.Engine.Displacement != 0)
            {
                sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
            }
            else
            {
                sb.AppendLine($"    Displacement: n/a");
            }

            if (this.Engine.Efficiency != null)
            {
                sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            }
            else
            {
                sb.AppendLine($"    Efficiency: n/a");
            }

            if (this.Weight != 0)
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }
            else
            {
                sb.AppendLine($"  Weight: n/a");
            }

            if (this.Color != null)
            {
                sb.Append($"  Color: {this.Color}");
            }
            else
            {
                sb.Append($"  Color: n/a");
            }


            return sb.ToString();

        }
    }
}
