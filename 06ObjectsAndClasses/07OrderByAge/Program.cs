using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splittedInput = input.Split(' ');
                string name = splittedInput[0];
                string iD = splittedInput[1];
                int age = int.Parse(splittedInput[2]);

                Person person = new Person(name, iD, age);
                people.Add(person);

                input = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();
            people.ForEach(x => Console.WriteLine(x));


        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string iD, int age)
        {
            this.Name = name;
            this.ID = iD;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
