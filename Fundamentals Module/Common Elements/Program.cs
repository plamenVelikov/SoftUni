using System;

namespace Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(' ');
            string[] arrTwo= Console.ReadLine().Split(' ');

            foreach (var currElement in arrOne)
            {
                foreach (var currElementTwo in arrTwo)
                {
                    if (currElement == currElementTwo)
                    {
                        Console.Write($"{currElement} ");
                        break;
                    }
                }
            }
        }
    }
}
