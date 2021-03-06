using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            Dictionary<char, int> countChars = new Dictionary<char, int>();

            for (int i = 0; i < input.Count; i++)
            {
                string currentWord = input[i];

                for (int j = 0; j < currentWord.Length; j++)
                {
                    if (!countChars.ContainsKey(currentWord[j]))
                    {
                        countChars[currentWord[j]] = 1;
                    }
                    else
                    {
                        countChars[currentWord[j]]++;
                    }
                }
            }

            foreach (var item in countChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
