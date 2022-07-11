using System;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] people = new int[num];
            int sum = 0;
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }
            foreach (var person in people)
            {
                Console.Write($"{person} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
