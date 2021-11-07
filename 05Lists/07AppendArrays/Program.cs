using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();


            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> work = numbers[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


                for (int j = 0; j < work.Count; j++)
                {

                    Console.Write($"{work[j]} ");


                }

            }
        }
    }
}
