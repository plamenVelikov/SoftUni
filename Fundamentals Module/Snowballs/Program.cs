using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSnowballs = int.Parse(Console.ReadLine());
            BigInteger snowballValueMax = 0;
            string output = null;
            for (int i = 0; i < numSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValueTemp = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValueTemp >= snowballValueMax)
                {
                    snowballValueMax = snowballValueTemp;
                    output = $"{snowballSnow} : {snowballTime} = {snowballValueMax} ({snowballQuality})";
                }
            }
            Console.WriteLine(output);
        }
    }
}
