using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();

            List<string> input = Console.ReadLine().Split().ToList();

            while (input[0] != "End")
            {
                Person person = new Person();
                {
                    person.Name = input[0];
                    person.Id = input[1];
                    person.Age = int.Parse(input[2]);
                }
                if (list.Any(x => x.Id == person.Id))
                {
                    list.RemoveAll(x => x.Id == person.Id);
                    list.Add(person);
                }
                else
                {
                    list.Add(person);
                }


                input = Console.ReadLine().Split().ToList();
            }
            list = list.OrderBy(x => x.Age).ToList();

            foreach (Person person in list)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }

    }
    public class Person
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }
}

