using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] splitedInput = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                    string side = splitedInput[0];
                    string user = splitedInput[1];

                    bool isExist = false;

                    foreach (var item in forceBook)
                    {
                        if (item.Value.Contains(user))
                        {
                            isExist = true;
                            break;
                        }
                    }

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook.Add(side, new List<string>());

                    }
                    if (!forceBook[side].Contains(user) && !isExist)
                    {
                        forceBook[side].Add(user);
                    }


                }
                else
                {
                    string[] splitedInput = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    string user = splitedInput[0];
                    string side = splitedInput[1];

                    bool isExist = false;
                    string currentSide = "";

                    foreach (var item in forceBook)
                    {
                        if (item.Value.Contains(user))
                        {
                            isExist = true;
                            currentSide = item.Key;
                            break;
                        }
                    }

                    if (isExist)
                    {
                        forceBook[currentSide].Remove(user);

                    }
                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook.Add(side, new List<string>());

                    }
                    if (!forceBook[side].Contains(user))
                    {
                        forceBook[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");

                    }

                  
                }

            }

            foreach (var item in forceBook.OrderByDescending(x => x.Value.Count)
                .ThenBy(n => n.Key)
                .Where(c => c.Value.Count != 0))
            {

                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                foreach (var user in item.Value.OrderBy(u => u))
                {
                    Console.WriteLine($"! {user}");
                }


            }
        }
    }
}
