using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> partyList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] commands = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();
            while (commands[0] != "Print")
            {

                if (commands[0] == "Add filter")
                {
                    filters.Add(commands[1] + commands[2], GetPredicate(commands[1], commands[2]));
                }
                else
                {
                    filters.Remove(commands[1] + commands[2]);
                }
                commands = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var filter in filters)
            {
                partyList.RemoveAll(filter.Value);
            }
            Console.WriteLine(String.Join(" ", partyList));
        }

        public static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with":
                    return s => s.StartsWith(value);
                case "Ends with":
                    return s => s.EndsWith(value);
                case "Length":
                    return s => s.Length == int.Parse(value);
                case "Contains":
                    return s => s.Contains(value);

                default:
                    return default(Predicate<string>);
            }

        }
    }
}
