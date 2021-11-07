using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> final = new Dictionary<string, Product>();

            

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] splittedInput = input.Split();
                string name = splittedInput[0];
                double price = double.Parse(splittedInput[1]);
                int quantity = int.Parse(splittedInput[2]);

                Product product = new Product(name, price, quantity);
                
                if (!final.ContainsKey(name))
                {
                    final.Add(name, product);
                   
                }
                else
                {
                    (final[name] as Product).Quantity += quantity;
                    if ((final[name] as Product).Price != price)
                    {
                        (final[name] as Product).Price = price;
                    }  


                    
                }
            }

            foreach (var item in final.Values)
            {
                Console.WriteLine($"{item.Name} -> {(item.Price * item.Quantity):f2}");
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

       public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
       
    }
}
