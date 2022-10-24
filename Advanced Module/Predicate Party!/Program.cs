using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;

namespace Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> partyList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            while (commands[0] != "Party!")
            {

                if (commands[0] == "Remove")
                {
                    partyList.RemoveAll(GetPredicate(commands[1], commands[2]));
                }
                else
                {
                    List<string> doubledList = partyList.FindAll(GetPredicate(commands[1], commands[2]));
                    int index = partyList.FindIndex(GetPredicate(commands[1], commands[2]));
                    if (index >= 0)
                    {
                        partyList.InsertRange(index, doubledList);
                    }

                }


                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (partyList.Any())
            {
                Console.WriteLine($"{string.Join(", ", partyList)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith":
                    return s => s.StartsWith(value);
                case "EndsWith":
                    return s => s.EndsWith(value);
                case "Length":
                    return s => s.Length == int.Parse(value);

                default:
                    return default(Predicate<string>);
            }

        }
    }
}
