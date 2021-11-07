using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                    .Split();
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials["motes"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["shards"] = 0;

            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            while (true)
            {
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "motes")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterials[material] -= 250;
                            keyMaterials = keyMaterials
                                .OrderByDescending(x => x.Value)
                                .ThenBy(x => x.Key)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                            foreach (var kvp in keyMaterials)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                            foreach (var kvp in junkMaterials)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                            return;

                        }
                    }
                    else if (material == "fragments")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMaterials[material] -= 250;
                            keyMaterials = keyMaterials
                                .OrderByDescending(x => x.Value)
                                .ThenBy(x => x.Key)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                            foreach (var kvp in keyMaterials)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                            foreach (var kvp in junkMaterials)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                            return;

                        }
                    }
                    else if (material == "shards")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterials[material] -= 250;
                            keyMaterials = keyMaterials
                                .OrderByDescending(x => x.Value)
                                .ThenBy(x => x.Key)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                            foreach (var kvp in keyMaterials)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                            foreach (var kvp in junkMaterials)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                            return;

                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }


                }

                input = Console.ReadLine()
                    .Split();

            }
        }
    }
}
