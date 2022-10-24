using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(inputData[0], int.Parse(inputData[1]));
                people.Add(person);
            }

            var selectedPeople = people.Where(x => x.Age > 30).ToList();

            foreach (var person in selectedPeople.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
