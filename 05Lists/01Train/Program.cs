using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string[] inputCommand = Console.ReadLine()
                .Split(' ')
                .ToArray();

            while (inputCommand[0] != "end")
            {
                string command = inputCommand[0];

                if (command == "Add")
                {
                    int countAdd = int.Parse(inputCommand[1]);
                    wagons.Add(countAdd);
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        
                        int passengersForAdd = int.Parse(inputCommand[0]);

                        if (wagons[i] +  passengersForAdd <= maxCapacity)
                        {
                            wagons[i] += passengersForAdd;
                            break;
                        }
                    }
                }

                
                inputCommand = Console.ReadLine()
                .Split(' ')
                .ToArray();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
