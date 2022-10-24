using System;
using System.Linq;

namespace GenericBoxofString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double item = double.Parse(Console.ReadLine());
                box.Items.Add(item);
            }
            double element = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Comparer(element));

            

            

        }
    }
}
