using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string eMail = Console.ReadLine();

            while ((input = Console.ReadLine()) != "Complete")
            {
                string[] splitedInput = input.Split();
                string command = splitedInput[0];

                if (command == "Make")
                {
                    string model = splitedInput[1];

                    if (model == "Upper")
                    {
                        eMail = eMail.ToUpper();
                        Console.WriteLine(eMail);
                    }
                    else if (model == "Lower")
                    {
                        eMail = eMail.ToLower();
                        Console.WriteLine(eMail);
                    }
                }
                else if (command == "GetDomain")
                {
                    int count = int.Parse(splitedInput[1]);
                    int length = eMail.Length;
                    int startIndex = length - count;
                    string result = string.Empty;
                    result = eMail.Substring(startIndex);
                   

                    Console.WriteLine(result);
                }
                else if (command == "GetUsername")
                {
                    if (eMail.Contains('@'))
                    {

                        string result = string.Empty;

                        for (int i = 0; i < eMail.Length; i++)
                        {
                            
                            if (eMail[i] != '@')
                            {
                                result += eMail[i];
                            }
                            else
                            {
                                break;
                            }
                        }

                        Console.WriteLine(result);

                    }
                    else
                    {
                        Console.WriteLine($"The email {eMail} doesn't contain the @ symbol.");
                    }
                }
                else if (command == "Replace")
                {
                    string oldChar = splitedInput[1];
                    string newChar = "-";
                    
                    eMail = eMail.Replace(oldChar, newChar);
                    Console.WriteLine(eMail);
                }
                else if (command == "Encrypt")
                {
                    for (int i = 0; i < eMail.Length; i++)
                    {
                        int symbol = (int)(eMail[i]);

                        Console.Write($"{symbol} ");
                    }
                }
            }
        }
    }
}
