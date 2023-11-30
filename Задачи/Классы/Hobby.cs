using System;
using System.Collections.Generic;

namespace Задачи
{
    internal class Hobby
    {
        /// <summary>
        /// Делегат
        /// </summary>
        /// <param name="hobby"></param>
        /// <param name="person"></param>
        public delegate void HobbyDelegate(Hobbys hobby, List<Person> person);
        /// <summary>
        /// Метод, который показывает реакцию человека на событие
        /// </summary>
        /// <param name="hobby"></param>
        /// <param name="person"></param>
        public static void Reaction(Hobbys hobby, List<Person> person)
        {
            for (int i = 0; person.Count > i; i++)
            {
                if (person[i].hobby.Equals(hobby))
                {
                    Console.WriteLine($"{person[i].name} кричит от радости");
                }
            }
        }
    }
}
