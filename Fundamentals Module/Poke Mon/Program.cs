using System;

namespace Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            double halfPower = pokePower * 0.50;
            int pokeCount = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokeCount++;

                if (pokePower == halfPower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCount);
        }
    }
}
