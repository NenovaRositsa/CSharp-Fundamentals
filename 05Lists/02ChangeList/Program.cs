using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "end")
            {
                string command = input[0];
                int element = int.Parse(input[1]);

                if (command == "Delete")
                {
                    numbers.RemoveAll(n => n == element);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(input[2]);

                    numbers.Insert(index, element);

                }


                input = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
