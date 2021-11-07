using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double mark = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                    students[name].Add(mark);
                }
                else
                {
                    students[name].Add(mark);
                }


            }

            Dictionary<string, double> filteredStudents = new Dictionary<string, double>();

            foreach (var item in students)
            {
                double grade = item.Value.Sum() / item.Value.Count;

                if (grade >= 4.50)
                {
                    filteredStudents.Add(item.Key, grade);
                }
            }

            foreach (var item in filteredStudents.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
