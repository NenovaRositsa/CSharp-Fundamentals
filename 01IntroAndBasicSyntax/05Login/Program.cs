using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            char[] passwordCharacter = userName.ToCharArray();
            Array.Reverse(passwordCharacter);
            string password = string.Empty;

            for (int i = 0; i < passwordCharacter.Length; i++)
            {
                password += passwordCharacter[i];
            }

            for (int i = 0; i < 4; i++)
            {

                string input = Console.ReadLine();

                if (i == 3)
                {
                    if (password == input)
                    {
                        Console.WriteLine($"User {userName} logged in.");


                    }
                    else
                    {
                        Console.WriteLine($"User {userName} blocked!");
                    }
                    return;
                }

                if (password == input)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

        }
    }
}
