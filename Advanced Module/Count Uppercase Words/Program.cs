using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> filter = x => char.IsUpper(x[0]);
            List<string> list = new List<string>();
            list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => filter(x)).ToList();


            foreach (var word in list)
            {
                Console.WriteLine(word);
            }
        }
    }
}
