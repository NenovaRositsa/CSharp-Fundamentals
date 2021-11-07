using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companiesEmployees = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInput = input
                    .Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string companyName = splittedInput[0];
                string employeeID = splittedInput[1];

                if (!companiesEmployees.ContainsKey(companyName))
                {
                    companiesEmployees.Add(companyName, new List<string>());
                    companiesEmployees[companyName].Add(employeeID);

                }
                else
                {
                    if (!companiesEmployees[companyName].Contains(employeeID))
                    {
                        companiesEmployees[companyName].Add(employeeID);
                    }
                }
            }

            foreach (var item in companiesEmployees.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var employ in item.Value)
                {
                    Console.WriteLine($"--{employ}");
                }
            }
        }
    }
}
