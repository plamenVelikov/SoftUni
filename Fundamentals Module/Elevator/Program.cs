using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int numCapacity = int.Parse(Console.ReadLine());

            int y = numPeople / numCapacity;

            if (numPeople % numCapacity == 0)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(y + 1);
            }
        }
    }
}
