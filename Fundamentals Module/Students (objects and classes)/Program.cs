using System;
using System.Collections.Generic;
using System.Linq;

namespace Students__objects_and_classes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Student> listStudents = new List<Student>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Student student = new Student(input[0], input[1], double.Parse(input[2]));
                listStudents.Add(student);

            }

            List<Student> orderedStudents = listStudents.OrderByDescending(x => x.Grade).ToList();
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
