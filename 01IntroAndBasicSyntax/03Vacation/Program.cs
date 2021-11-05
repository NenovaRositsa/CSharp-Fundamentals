using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfWwek = Console.ReadLine();

            double price = 0.00;
            double totalPrice = 0.00;

            if (dayOfWwek == "Friday")
            {
                switch (typeOfTheGroup)
                {
                    case "Students":
                        price = people * 8.45;
                        break;
                    case "Business":
                        price = people * 10.90;
                        break;
                    case "Regular":
                        price = people * 15;
                        break;

                }
            }
            else if (dayOfWwek == "Saturday")
            {
                switch (typeOfTheGroup)
                {
                    case "Students":
                        price = people * 9.80;
                        break;
                    case "Business":
                        price = people * 15.60;
                        break;
                    case "Regular":
                        price = people * 20;
                        break;

                }
            }
            else if (dayOfWwek == "Sunday")
            {
                switch (typeOfTheGroup)
                {
                    case "Students":
                        price = people * 10.46;
                        break;
                    case "Business":
                        price = people * 16;
                        break;
                    case "Regular":
                        price = people * 22.50;
                        break;


                }

            }
            if (typeOfTheGroup == "Students" && people >= 30)
            {
                totalPrice = price - (price * 0.15);
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else if (typeOfTheGroup == "Business" && people >= 100)
            {
                totalPrice = price - ((price / people) * 10);
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else if (typeOfTheGroup == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice = price - (price * 0.05);
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else
            {
                totalPrice = price;
                Console.WriteLine($"Total price: {totalPrice:f2}");

            }


        }
    }
}
