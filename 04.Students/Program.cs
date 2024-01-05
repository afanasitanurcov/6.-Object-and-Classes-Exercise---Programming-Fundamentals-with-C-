using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            List<Student> list = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

            Student student = new Student();
                {
                    student.FirstName = input[0];
                    student.LastName = input[1];
                    student.Grade = double.Parse(input[2]);
                }
                list.Add(student);
            }
            list = list.OrderByDescending(x => x.Grade).ToList();

            foreach (Student i in list)
            {
                Console.WriteLine(i);
            }

        }
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
