using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            decimal totalIncome = 0;

            string pattern = @"%(?<name>[A-Z]{1}[a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[0-9]+\.?[0-9]+)\$";

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match matchedOrder = Regex.Match(input, pattern);

                if (matchedOrder.Success)
                {
                    string name = matchedOrder.Groups["name"].Value;
                    string product = matchedOrder.Groups["product"].Value;
                    decimal count = decimal.Parse(matchedOrder.Groups["count"].Value);
                    decimal price = decimal.Parse(matchedOrder.Groups["price"].Value);
                    decimal totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");

                }
                else
                {
                    continue;
                }
               


            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
