using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"(?<health>[^0-9\+\-\*\/\.])";
            string damagePattern = @"(?<damage>[-+]*?[\d+\.?\d+]+)";

            List<Demon> result = new List<Demon>();

            string[] demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < demons.Length; i++)
            {
                string nameDemon = demons[i];

               
                
                    MatchCollection matchedForHealth = Regex.Matches(nameDemon, healthPattern);

                    int healthDemon = 0;

                    for (int j = 0; j < matchedForHealth.Count; j++)
                    {
                        healthDemon += char.Parse(matchedForHealth[j].ToString());
                    }

                    double damage = 0.00;

                    MatchCollection matchedForDamage = Regex.Matches(nameDemon, damagePattern);

                    for (int k = 0; k < matchedForDamage.Count; k++)
                    {
                        damage += double.Parse(matchedForDamage[k].ToString());
                    }

                    for (int r = 0; r < nameDemon.Length; r++)
                    {
                        if (nameDemon[r] == '*')
                        {
                            damage *= 2;
                        }
                        else if (nameDemon[r] == '/')
                        {
                            damage /= 2;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    Demon currentDemon = new Demon(nameDemon, healthDemon, damage);
                    result.Add(currentDemon);

                

            }

            foreach (var demon in result.OrderBy(x => x.NameDemon))
            {
                Console.WriteLine($"{demon.NameDemon} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }

    class Demon
    {
        public string NameDemon { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public Demon(string nameDemon, int health, double damage)
        {
            this.NameDemon = nameDemon;
            this.Health = health;
            this.Damage = damage;
        }
    }
}
