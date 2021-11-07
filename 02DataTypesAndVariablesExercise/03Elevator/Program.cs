using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;

            if (countOfPeople % capacity == 0)
            {
                courses = countOfPeople / capacity;
            }
            else
            {
                courses = (countOfPeople / capacity) + 1;
            }

            Console.WriteLine(courses);
        }
    }
}
