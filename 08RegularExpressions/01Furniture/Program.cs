using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            decimal totalSum = 0;

            List<string> furnitures = new List<string>();

            while ((input = Console.ReadLine()) != "Purchase")
            {
                string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>[0-9]+\.?[0-9]*)!(?<quantity>\d+)";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                  
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    totalSum += price * quantity;

                    furnitures.Add(name);


                }

               
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in furnitures)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(string.Join(Environment.NewLine, furnitures));
            Console.WriteLine($"Total money spend: {totalSum:f2}");
           
            
        }
    }
}

//string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+.\d{2}|\d+)!(?<quantity>\d+)";
