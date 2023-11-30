using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Задачи.Hobby;

namespace Задачи
{
    internal class Program
    {
        
        public static T[] Concat<T>(params T[][] arrays)
        {
            var result = new T[arrays.Sum(a => a.Length)];
            int offset = 0;
            foreach (T[] array in arrays)
            {
                array.CopyTo(result, offset);
                offset += array.Length;
            }
            return result;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задача 1");
            Console.WriteLine("Мероприятие для студентов");
            List<string> names = new List<string>();
            List<string> groups = new List<string>();
            string filePath = "student.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    names.Add(parts[0].Trim());
                    groups.Add(parts[1].Trim());
                }
            }
            Student student_1 = new Student(names[0], groups[0]);
            Student student_2 = new Student(names[1], groups[1]);
            Student student_3 = new Student(names[2], groups[2]);
            Student student_4 = new Student(names[3], groups[3]);
            Student student_5 = new Student(names[4], groups[4]);
            Student student_6 = new Student(names[5], groups[5]);
            Student student_7 = new Student(names[6], groups[6]);
            Student student_8 = new Student(names[7], groups[7]);
            Student student_9 = new Student(names[8], groups[8]);
            Student student_10 = new Student(names[9], groups[9]);
            Student student_11 = new Student(names[10], groups[10]);
            Student student_12 = new Student(names[11], groups[11]);
            Student student_13 = new Student(names[12], groups[12]);
            Student student_14 = new Student(names[13], groups[13]);
            Student student_15 = new Student(names[14], groups[14]);
            List<Student> students = new List<Student>() { student_1, student_2, student_3, student_4, student_5, student_6, student_7
            , student_8 , student_9, student_10, student_11, student_12, student_13, student_14, student_15};
            Console.WriteLine();
            Events events_1 = new Events("Голодные игры", new DateTime(2023,11,30, 16, 00, 00), students, 5, "Мерч_Кфу");
            events_1.Inform_Event(events_1, "The_Hunger_Games.txt");
            Console.WriteLine();
            string[] event_1 = events_1.Listing_Students(events_1, students, "The_Hunger_Games.txt");
            Console.WriteLine();
            Events events_2 = new Events("Поле чудес", new DateTime(2023, 12, 05, 18, 30, 00), students, 6, "Автомобиль");
            Console.WriteLine();
            events_2.Inform_Event(events_2, "Field_of_Dreams.txt");
            Console.WriteLine();
            string[] event_2 = events_2.Listing_Students(events_2, students, "Field_of_Dreams.txt");
            Console.WriteLine();
            Events events_3 = new Events("КВН", new DateTime(2023, 12, 10, 18, 00, 00), students, 4, "банка огурцов");
            events_3.Inform_Event(events_3, "KVN.txt");
            Console.WriteLine();
            string[] event_3 = events_3.Listing_Students(events_3, students, "KVN.txt");
            Console.WriteLine();
            Console.WriteLine("Определим халявщиков");
            events_3.Freeloader(students);
            Console.WriteLine();
            Events events_4 = new Events("Лотерея", new DateTime(2023, 12, 15, 17, 00, 00), students, 6, "10000 рублей");
            Console.WriteLine();
            events_4.Inform_Event(events_4, "Lottery.txt");
            Console.WriteLine();
            string[] event_4 = events_4.Listing_Students_Freeloader(events_4, students, "Lottery.txt");
            Console.WriteLine();
            Console.WriteLine("Появились желающие, которые хотели поучавствовать в следующем мероприятии");
            Console.WriteLine();
            Events events_5 = new Events("Театральная постановка", new DateTime(2023, 12, 25, 18, 00, 00), students, 8, "Оскар");
            events_5.Choice(students);
            Console.WriteLine();
            events_5.Inform_Event(events_5, "Theatrical_performance.txt");
            Console.WriteLine();
            string[] event_5 = events_5.Listing_Students_Choice(events_5, students, "Theatrical_performance.txt");
            Console.WriteLine();
            string[] all_events = Concat(event_1, event_2, event_3, event_4, event_5);
            
            for (int i = 0; i < all_events.Length; i++)
            {
                using (StreamWriter writer_1 = new StreamWriter("All_Events.txt", true))
                {
                    writer_1.WriteLine(all_events[i]);
                }
            }
           
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            Console.WriteLine();
            
            Console.WriteLine("Задача 2");
            Console.WriteLine("Реакции на события");
            Console.WriteLine();
            Person person_1 = new Person("Даниил", Hobbys.игры);
            Person person_2 = new Person("Влад", Hobbys.спорт);
            Person person_3 = new Person("Диана", Hobbys.сериалы);
            Person person_4 = new Person("Илья", Hobbys.прогать);
            Person person_5 = new Person("Камиля", Hobbys.гулять);
            List<Person> persons = new List<Person> { person_1, person_2, person_3, person_4, person_5 };
            Hobbys hobbys = Hobbys.спорт;
            HobbyDelegate hobbyDelegate = Reaction;
            hobbyDelegate(hobbys, persons);
            Console.WriteLine();
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
        }
    }
}
