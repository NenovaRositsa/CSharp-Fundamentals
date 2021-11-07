using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesStudents = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] splittedInput = input.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                string course = splittedInput[0];
                string nameStudent = splittedInput[1];

                if (!coursesStudents.ContainsKey(course))
                {
                    coursesStudents.Add(course, new List<string>());
                    coursesStudents[course].Add(nameStudent);
                    
                }
                else
                {
                    coursesStudents[course].Add(nameStudent);
                }


            }


            foreach (var course in coursesStudents
                .OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine("{0}: {1}", course.Key, course.Value.Count);

                // 1. Как да сортирам листа в речника по азбучен ред?            
                foreach (var name in course.Value.OrderBy(n => n))
                {
                    Console.WriteLine("-- {0}", name);
                }
            }
        }
    }
}
