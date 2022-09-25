using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> register = new HashSet<string>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "IN":
                        register.Add(input[1]);
                        break;
                    case "OUT":
                        register.Remove(input[1]);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (register.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in register)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
