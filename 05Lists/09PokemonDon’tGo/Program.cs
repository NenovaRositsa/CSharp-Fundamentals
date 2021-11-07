using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int sumOfRemovedElements = 0;

            while (distances.Count != 0)
            {
                int indexes = int.Parse(Console.ReadLine());
                
                if (indexes < 0)
                {
                    int lastElement = distances[distances.Count - 1];
                    int removedElement = distances[0];
                    sumOfRemovedElements += removedElement;
                    distances.RemoveAt(0);
                    distances.Insert(0, lastElement);

                    for (int i = 0; i < distances.Count; i++)
                    {
                        int currentElement = distances[i];
                        if (currentElement <= removedElement)
                        {
                            currentElement += removedElement;
                            distances[i] = currentElement;
                        }
                        else
                        {
                            currentElement -= removedElement;
                            distances[i] = currentElement;
                        }
                    }

                }
                else if (indexes > distances.Count - 1)
                {
                    int removedElement = distances[distances.Count - 1];
                    int firstElement = distances[0];
                    sumOfRemovedElements += removedElement;
                    distances.RemoveAt(distances.Count - 1);
                    distances.Add(firstElement);

                    for (int i = 0; i < distances.Count; i++)
                    {
                        int currentElement = distances[i];
                        if (currentElement <= removedElement)
                        {
                            currentElement += removedElement;
                            distances[i] = currentElement;
                        }
                        else
                        {
                            currentElement -= removedElement;
                            distances[i] = currentElement;
                        }
                    }

                }
                else
                {
                    int removedElement = distances[indexes];
                    sumOfRemovedElements += removedElement;
                    distances.RemoveAt(indexes);

                    for (int i = 0; i < distances.Count; i++)
                    {
                        int currentElement = distances[i];
                        if (currentElement <= removedElement)
                        {
                            currentElement += removedElement;
                            distances[i] = currentElement;
                        }
                        else
                        {
                            currentElement -= removedElement;
                            distances[i] = currentElement;
                        }
                    }
                }
                
            }

            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
