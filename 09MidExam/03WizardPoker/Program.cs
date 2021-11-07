using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard_Poker_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                .Split(':')
                .ToList();
            List<string> resultList = new List<string>();
            string input;

            while ((input = Console.ReadLine()) != "Ready")
            {
                string[] splittedInput = input.Split(' ');
                string command = splittedInput[0];

                if (command == "Add")
                {
                    string cardName = splittedInput[1];

                    if (cards.Contains(cardName))
                    {
                        
                        resultList.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command == "Insert")
                {
                    string cardName = splittedInput[1];
                    int index = int.Parse(splittedInput[2]);

                    if (cards.Contains(cardName) && index >= 0 && index < resultList.Count)
                    {
                        
                        resultList.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (command == "Remove")
                {
                    string cardName = splittedInput[1];

                    if (resultList.Contains(cardName))
                    {
                        resultList.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command == "Swap")
                {
                    string name1 = splittedInput[1];
                    string name2 = splittedInput[2];

                    if (resultList.Contains(name1) && resultList.Contains(name2))
                    {
                        int index1 = resultList.IndexOf(name1);
                        int index2 = resultList.IndexOf(name2);

                        resultList[index1] = name2;
                        resultList[index2] = name1;

                    }
                    
                }
                else if (command == "Shuffle")
                {
                    resultList.Reverse();
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
