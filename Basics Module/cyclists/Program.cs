using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Първият ред – броят младши велосипедисти.Цяло число в интервала[1…100]
            //•	Вторият ред – броят старши велосипедисти.Цяло число в интервала[1… 100]
            //•	Третият ред – вид трасе – "trail", "cross-country", "downhill" или "road"

            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            double taxJun = 0.0;
            double taxSen = 0.0;
            int everybody = juniors + seniors;
            double totalSum = 0.0;

            switch (type)
            {
                case "trail":
                    taxJun = 5.50;
                    taxSen = 7;
                    break;

                case "cross-country":
                    taxJun = 8;
                    taxSen = 9.50;

                    if (everybody >= 50)
                    {
                        taxJun *= 0.75;
                        taxSen *= 0.75;
                    }
                    break;
                case "downhill":
                    taxJun = 12.25;
                    taxSen = 13.75;
                    break;
                case "road":
                    taxJun = 20;
                    taxSen = 21.50;
                    break;
                default:
                    break;
            }

            totalSum = (juniors * taxJun + seniors * taxSen) * 0.95;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
