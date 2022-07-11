using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> pList = new List<Person>();
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "End")
            {
                if (pList.Any(x => x.ID == input[1]))
                {
                    Person currPerson = pList.Find(x => x.ID == input[1]);
                    currPerson.Name = input[0];
                    currPerson.Age = int.Parse(input[2]);
                }
                else
                {
                    Person person = new Person();
                    person.Name = input[0];
                    person.ID = input[1];
                    person.Age = int.Parse(input[2]);
                    pList.Add(person);
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            if (pList.Count == 0)
            {
                return;
            }
            else
            {
                List<Person> orderedByAge = pList.OrderBy(x => x.Age).ToList();
                foreach (var person in orderedByAge)
                {
                    Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
                }
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
