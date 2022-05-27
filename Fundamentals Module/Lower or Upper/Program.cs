using System;

namespace Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            int index = Convert.ToInt32(character);

            if (index >= 65 && index <= 95)
            {
                Console.WriteLine("upper-case");
            }
            else if (index >= 97 && index <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
