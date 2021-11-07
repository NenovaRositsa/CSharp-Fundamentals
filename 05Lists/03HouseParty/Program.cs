using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<string> namesGuests = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                int length = input.Length;
                string name = input[0];

                if (length == 3)
                {
                    if (namesGuests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        namesGuests.Add(name);
                    }
                }
                else
                {
                    if (namesGuests.Contains(name))
                    {
                        namesGuests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }


            }

            foreach (string item in namesGuests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
