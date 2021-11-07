using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();

            while (input[0] != "End")
            {
                string command = input[0];

                if (command == "Add")
                {
                    int element = int.Parse(input[1]);
                    numbers.Add(element);
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, element);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(input[1]);
                    if (index < numbers.Count && index >= 0)
                    {
                        
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (command == "Shift" && input[1] == "left")
                {
                    int count = int.Parse(input[2]);

                    for (int i = 0; i < count; i++)
                    {

                        int currentNum = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(currentNum);


                    }
                }
                else if (command == "Shift" && input[1] == "right")
                {
                    int count = int.Parse(input[2]);

                    for (int i = 0; i < count; i++)
                    {

                        int currentNum = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, currentNum);


                    }
                }
                input = Console.ReadLine()
                .Split(' ')
                .ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

