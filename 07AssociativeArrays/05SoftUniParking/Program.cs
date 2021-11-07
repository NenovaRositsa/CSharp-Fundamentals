using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];


                if (command == "register")
                {
                    
                    string userName = input[1];
                    string plateNumber = input[2];

                    if (!registeredUsers.ContainsKey(userName))
                    {
                        registeredUsers.Add(userName, plateNumber);
                        Console.WriteLine($"{userName} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    string userName = input[1];

                    if (!registeredUsers.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        registeredUsers.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
             }

            foreach (var kvp in registeredUsers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
