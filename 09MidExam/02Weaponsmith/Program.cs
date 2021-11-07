using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weaponsmith_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weaponName = Console.ReadLine()
                .Split('|')
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] splittedInput = input.Split(' ');
                string command = splittedInput[0];

                if (command == "Move" && splittedInput[1] == "Left")
                {
                    int index = int.Parse(splittedInput[2]);

                    if (index > 0 && index < weaponName.Count)
                    {
                        string nameIndex = weaponName[index];
                        string namePreviousIndex = weaponName[index - 1];

                        weaponName[index - 1] = nameIndex;
                        weaponName[index] = namePreviousIndex;
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "Move" && splittedInput[1] == "Right")
                {
                    int index = int.Parse(splittedInput[2]);

                    if (index >= 0 && index < weaponName.Count -1)
                    {
                        string nameIndex = weaponName[index];
                        string nameNextIndex = weaponName[index + 1];

                        weaponName[index + 1] = nameIndex;
                        weaponName[index] = nameNextIndex;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Check" && splittedInput[1] == "Even")
                {
                    List<string> evenItems = new List<string>();

                    for (int i = 0; i < weaponName.Count; i++)
                    {
                        if (i %2 == 0)
                        {
                            evenItems.Add(weaponName[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", evenItems));
                }
                else if (command == "Check" && splittedInput[1] == "Odd")
                {
                    List<string> oddItems = new List<string>();

                    for (int i = 0; i < weaponName.Count; i++)
                    {
                        if (i % 2 != 0 && i != 0)
                        {
                            oddItems.Add(weaponName[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", oddItems));
                }
            }

            

            Console.WriteLine($"You crafted {string.Join("", weaponName)}!");
         }
    }
}
