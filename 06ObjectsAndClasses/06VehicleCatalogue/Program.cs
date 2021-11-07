using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicle> catalogue = new List<Vehicle>();

            while (input != "End")
            {
                string[] splittedInput = input.Split(' ');
                string type = splittedInput[0];
                string model = splittedInput[1];
                string color = splittedInput[2];
                int horsePower = int.Parse(splittedInput[3]);


                Vehicle vehicle = new Vehicle(type, model, color, horsePower);

                catalogue.Add(vehicle);
                input = Console.ReadLine();
            }

            string modelForPrint;

            while ((modelForPrint = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(catalogue.Find(x => x.Model == modelForPrint));
            }


            List<Vehicle> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            var onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            if (onlyCars.Count > 0)
            {
                double averageHorsePowerCars = catalogue.Where(y => y.Type == "car").Average(x => x.HorsePower);

                Console.WriteLine($"Cars have average horsepower of: {averageHorsePowerCars:f2}.");


            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0)
            {
                double averageHorsePowerTrucks = catalogue.Where(y => y.Type == "truck").Average(x => x.HorsePower);

                Console.WriteLine($"Trucks have average horsepower of: {averageHorsePowerTrucks:f2}.");


            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }


        }


    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public override string ToString()
        {
            return

                $"Type: {UpperCaseFirstLetter(this.Type)}{Environment.NewLine}" +
                $"Model: {this.Model}{Environment.NewLine}" +
                $"Color: {this.Color}{Environment.NewLine}" +
                $"Horsepower: {this.HorsePower}";

        }

        public string UpperCaseFirstLetter(string s)
        {
            //// Check for empty string.
            //if (string.IsNullOrEmpty(s))
            //{
            //    return string.Empty;
            //}
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}





