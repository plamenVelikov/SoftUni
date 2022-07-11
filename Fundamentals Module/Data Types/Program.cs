using System;

namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string item = Console.ReadLine();

            if (type == "int")
            {
                PrintResult(type, Convert.ToInt32(item));
            }
            else if (type == "real")
            {
                PrintResult(type, Convert.ToDouble(item));
            }
            else if(type == "string")
            {
                PrintResult(type, item);
            }
            

        }

        static void PrintResult(string type, int item)
        {
            Console.WriteLine(item * 2);
            
        }
        static void PrintResult(string type, double item)
        {
            Console.WriteLine($"{item * 1.50:f2}");

        }
        static void PrintResult(string type, string item)
        {
            Console.WriteLine($"${item}$");

        }
    }
}
