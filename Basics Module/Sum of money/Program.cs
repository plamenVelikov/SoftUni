using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Брой монети по 1лв. - цяло положително число;
            //2.Брой монети по 2лв. - цяло положително число;
            //3.Брой банкноти по 5лв. - цяло положително число;
            //4.Сума - цяло положително число в интервала[1…1000];

            int numOne1Lev = int.Parse(Console.ReadLine());
            int numTwoLev = int.Parse(Console.ReadLine());
            int numFiveLev = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numOne1Lev; i++)
            {
                for (int j = 0; j <= numTwoLev; j++)
                {
                    for (int l = 0; l <= numFiveLev; l++)
                    {
                        int x = i * 1 + j * 2 + l * 5;
                        if (x == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {l} * 5 lv. = {x} lv.");
                        }
                    }
                }
            }

        }
    }
}
