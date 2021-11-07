using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> usersPoints = new Dictionary<string, int>();
            Dictionary<string, int> languageCount = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "exam finished")
            {
               
                string[] splitedInput = input.Split('-');
                if (splitedInput.Length < 3)
                {
                    string userName = splitedInput[0];
                    usersPoints.Remove(userName);
                    
                }
                else
                {
                    string userName = splitedInput[0];
                    string language = splitedInput[1];
                    int points = int.Parse(splitedInput[2]);

                    if (!usersPoints.ContainsKey(userName))
                    {
                        usersPoints.Add(userName, points);
                    }
                    else
                    {
                        if (usersPoints[userName] < points)
                        {
                            usersPoints[userName] = points;
                        }
                        
                    }

                    if (!languageCount.ContainsKey(language))
                    {
                        languageCount.Add(language, 1);
                    }
                    else
                    {
                        languageCount[language]++;
                    }

                }
                
            }

            Console.WriteLine("Results:");
            foreach (var kvp in usersPoints.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languageCount.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
