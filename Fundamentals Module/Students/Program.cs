using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] studentProps = Console.ReadLine().Split(' ');
            while (studentProps[0] != "end")
            {
                Student student = new Student();
                student.FirstName = studentProps[0];
                student.LastName = studentProps[1];
                student.Age = int.Parse(studentProps[2]);
                student.HomeTown = studentProps[3];

                students.Add(student);
                studentProps = Console.ReadLine().Split(' ');
            }
            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (city == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
