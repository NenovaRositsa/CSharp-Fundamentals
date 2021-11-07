using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex regex = new Regex(@"U\$(?<name>[A-Z]{1}[a-z]{2,})U\$P\@\$(?<password>[A-Za-z]{5,}\d+)P\@\$");

                Match matched = regex.Match(input);

                if (matched.Success)
                {
                    Console.WriteLine("Registration was successful");
                    string userName = matched.Groups["name"].Value;
                    string password = matched.Groups["password"].Value;
                    count++;

                    Console.WriteLine($"Username: {userName}, Password: {password}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }

            }

            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
