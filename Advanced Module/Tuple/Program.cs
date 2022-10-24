using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nameNameAdress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] nameLiters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] intDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Tuple<string, string, string> nameNameAdressX = new Tuple<string, string, string>()
            {
                FirstItem = $"{nameNameAdress[0]} {nameNameAdress[1]}",
                SecondItem = $"{nameNameAdress[2]}",
                ThirdItem = nameNameAdress.Length == 4 ? $"{nameNameAdress[3]}" : $"{nameNameAdress[3]} {nameNameAdress.Last()}"
            };

            Tuple<string, int, string> nameLitersX = new Tuple<string, int, string>()
            {
                FirstItem = $"{nameLiters[0]}",
                SecondItem = int.Parse(nameLiters[1]),
                ThirdItem = nameLiters[2] == "drunk" ? "True" : "False"
            };

            Tuple<string, double, string> intDoubleX = new Tuple<string, double, string>()
            {
                FirstItem = intDouble[0],
                SecondItem = double.Parse(intDouble[1]),
                ThirdItem = intDouble[2]
            };

            Console.WriteLine(nameNameAdressX.ToString());
            Console.WriteLine(nameLitersX.ToString());
            Console.WriteLine(intDoubleX.ToString());
        }
    }
}
