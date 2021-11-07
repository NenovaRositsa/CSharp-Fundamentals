using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> usersEmails = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] splitedInput = input
                    .Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                string command = splitedInput[0];

                if (command == "Add")
                {
                    string userName = splitedInput[1];

                    if (usersEmails.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} is already registered");
                    }
                    else
                    {
                        usersEmails.Add(userName, new List<string>());
                    }
                }
                else if (command == "Send")
                {
                    string userName = splitedInput[1];
                    string email = splitedInput[2];

                    usersEmails[userName].Add(email);
                }
                else if (command == "Delete")
                {
                    string userName = splitedInput[1];

                    if (usersEmails.ContainsKey(userName))
                    {
                        usersEmails.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} not found!");
                    }
                }
            }

            int count = usersEmails.Count;

            Console.WriteLine($"Users count: {count}");

            foreach (var user in usersEmails
                .OrderByDescending(x=>x.Value.Count)
                .ThenBy(x=>x.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var email in user.Value)
                    
                {
                    Console.WriteLine($"- {email}");
                }
            }
        }
    }
}
