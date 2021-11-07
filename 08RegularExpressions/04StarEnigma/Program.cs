using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[straSTRA]";
            string secondPattern = @"@(?<name>[a-zA-Z]+)[^@\-!:>]*:[0-9]+[^@\-!:>]*!(?<state>[AD])![^@\-!:>]*->[0-9]+";

            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

           

            for (int i = 0; i < n; i++)

            {
                string message = Console.ReadLine();
                char[] decryptedMessage = new char[message.Length];
           

                MatchCollection matchedLetters = Regex.Matches(message, pattern);
                int key = matchedLetters.Count;

                for (int j= 0;  j < message.Length;  j++)
                {
                    char newValue = (char)(message[j] - key);
                    decryptedMessage[j] = newValue;

                }

                string decryptedMessageAsString = new string(decryptedMessage);

                Match matched = Regex.Match(decryptedMessageAsString, secondPattern);

                if (matched.Success)
                {


                    string namePlanet = matched.Groups["name"].Value;
                    var state = matched.Groups["state"].Value;

                    if (state == "A")
                    {
                        attackedPlanets.Add(namePlanet);
                    }
                    else
                    {
                        destroyedPlanets.Add(namePlanet);
                    }
                }
                else
                {
                    continue;
                }
            }

            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
                
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

           
        }
    }
}
