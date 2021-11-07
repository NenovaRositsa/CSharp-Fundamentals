using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialShedule = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> inputCommands = Console.ReadLine()
                .Split(':')
                .ToList();

            while (inputCommands[0] != "course start")
            {
                string command = inputCommands[0];
                string lessonTitle = inputCommands[1];

                if (command == "Add" && !initialShedule.Contains(lessonTitle))
                {
                    initialShedule.Add(lessonTitle);
                }
                else if (command == "Insert" && !initialShedule.Contains(lessonTitle))
                {
                    int index = int.Parse(inputCommands[2]);
                    initialShedule.Insert(index, lessonTitle);
                }
                else if (command == "Remove" && initialShedule.Contains(lessonTitle))
                {
                    int lessonIndex = initialShedule.IndexOf(lessonTitle);

                    if (initialShedule[lessonIndex + 1].Contains("Exercise"))
                    {
                        initialShedule.RemoveAt(lessonIndex);
                        initialShedule.RemoveAt(lessonIndex + 1);
                    }
                    else
                    {
                        initialShedule.RemoveAt(lessonIndex);
                    }
                }
                else if (command == "Swap")
                {
                    string lessonTitleSecond = inputCommands[2];

                    if (initialShedule.Contains(lessonTitle) && initialShedule.Contains(lessonTitleSecond))
                    {
                        int firstLessonIndex = initialShedule.IndexOf(lessonTitle);
                        int secondLessonIndex = initialShedule.IndexOf(lessonTitleSecond);

                        initialShedule[firstLessonIndex] = lessonTitleSecond;
                        initialShedule[secondLessonIndex] = lessonTitle;

                        if (firstLessonIndex+1 <= initialShedule.Count && secondLessonIndex + 1 <= initialShedule.Count)
                        {
                            string firstLessonExercise = $"{lessonTitle}-Exercise";
                            string secondLessonExercise = $"{lessonTitleSecond}-Exercise";

                            string firstIndexAfterFirstLesson = initialShedule[firstLessonIndex + 1];
                            string firstIndexAfterSecondLesson = initialShedule[secondLessonIndex + 1];

                            if (firstIndexAfterFirstLesson.Contains(firstLessonExercise))
                            {

                                initialShedule[secondLessonIndex + 1] = firstLessonExercise;
                                
                               
                                
                            }
                            if (firstIndexAfterSecondLesson.Contains(secondLessonExercise))
                            {
                                initialShedule[firstLessonIndex + 1] = secondLessonExercise;
                                
                               
                                
                            }
                        }

                       
                    }
                }

                else if (command == "Exercise")
                {
                    string lessonExercise = $"{lessonTitle}-Exercise";

                    if (initialShedule.Contains(lessonTitle))
                    {
                        if (!initialShedule.Contains(lessonExercise))
                        {
                            int indexLesson = initialShedule.IndexOf(lessonTitle);
                            initialShedule.Insert(indexLesson + 1, lessonExercise);
                        }
                    }
                    else
                    {
                        initialShedule.Add(lessonTitle);
                        initialShedule.Add(lessonExercise);
                    }

                }

                inputCommands = Console.ReadLine()
                .Split(':')
                .ToList();
            }

            int count = 1;

            foreach (string lesson in initialShedule)
            {
                Console.WriteLine($"{count}.{lesson}");
                count++;
            }


        }
    }
}
