using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Задачи
{
    internal class Events
    {
        internal string name { get; set; }
        internal DateTime time { get; set; }
        internal List<Student> students { get; set; }
        internal int number_of_part { get; set; }
        internal string draw { get; set; }
        public Events(string name, DateTime time, List<Student> students, int number_of_part, string draw)
        {
            this.name = name;
            this.time = time;
            this.students = students;
            this.number_of_part = number_of_part;
            this.draw = draw;
        }
        /// <summary>
        /// Метод, который записывает название мероприятия в файл : мероприятие
        /// </summary>
        /// <param name="events"></param>
        public void Inform_Event(Events events, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Мероприятие: {events.name} на {time}");
            }
            Console.WriteLine($"Мероприятие: {events.name} на {time}");
        }
        public string[] Listing_Students(Events events, List<Student> students, string filePath)
        {
            int[] array = new int[events.number_of_part];
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < events.number_of_part; i++)
            {
                int count = random.Next(0, 14);
                if (!array.Contains(count))
                {
                    array[i] += count;
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                    }
                    Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                }
                else
                {
                    count = random.Next(0, 14);
                    if (!array.Contains(count))
                    {
                        array[i] += count;
                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                        }
                        Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                    }
                    else
                    {
                        count = random.Next(0, 14);
                        if (!array.Contains(count))
                        {
                            array[i] += count;
                            using (StreamWriter writer = new StreamWriter(filePath, true))
                            {
                                writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                            }
                            Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                        }
                        else
                        {
                            count = random.Next(0, 14);
                            if (!array.Contains(count))
                            {
                                array[i] += count;
                                using (StreamWriter writer = new StreamWriter(filePath, true))
                                {
                                    writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                                }
                                Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                            }
                            else
                            {
                                using (StreamWriter writer = new StreamWriter(filePath, true))
                                {
                                    writer.WriteLine($"Участник не нашёлся");
                                }
                                Console.WriteLine($"Участник не нашёлся");
                            }
                        }
                    }
                }
                students[count].employment = Employment.Учавствующий;
            }
            string[] inform = new string[array.Length + 1];
            string[] raffle = new string[1];
            raffle[0] = "Розыгрыша не будет, так пришла только одна группа";
            string[] counts = new string[1];
            for (int i = 0; array.Length > i; i++)
            {
                inform[i] = students[array[i]].group;
            }
            if (inform.Contains("321"))
            {
                if (inform.Contains("322"))
                {
                    counts[0] = $"В {events.time} пройдет розыгрыш на {events.draw}";
                    raffle = new string[array.Length + 1];
                    
                    for (int i = 0; array.Length > i; i++)
                    {
                        raffle[i] += $"Участник: {students[array[i]].name}, группа: {students[array[i]].group}";
                    }
                    string[] result = counts.Concat(raffle).ToArray();
                    return result;
                }
                else
                {
                    return raffle;
                }
            }
            else
            {
                return raffle;
            }
        }

        public void Freeloader(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].employment == Employment.Не_учавствующий)
                {
                    students[i].employment = Employment.Халявщик;
                    Console.WriteLine($"Студент: {students[i].name} из группы {students[i].group} оказался халявщиком");
                }
            }
        }
   
        public string[] Listing_Students_Freeloader(Events events, List<Student> students, string filePath)
        {
            int[] array = new int[events.number_of_part];
            Random random = new Random((int)DateTime.Now.Ticks);
            int a = 0;
            for (int i = 0;i < students.Count; i++)
            {
                if (students[i].employment == Employment.Халявщик)
                {
                    if (random.Next(0, 9) > 4)
                    {
                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            writer.WriteLine($"Участник: {students[i].name}, группа: {students[i].group}");
                        }
                        Console.WriteLine($"Участник: {students[i].name}, группа: {students[i].group}");
                        students[i].employment = Employment.Учавствующий;
                        a++;
                    }
                    else
                    {
                        
                    }
                }
            }
            for (int i = 0; i < events.number_of_part - a; i++)
            {
                int count = random.Next(0, 14);
                if (!array.Contains(count))
                {
                    array[i] += count;
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                    }
                    Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                }
                else
                {
                    count = random.Next(0, 14);
                    if (!array.Contains(count))
                    {
                        array[i] += count;
                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                        }
                        Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                    }
                    else
                    {
                        count = random.Next(0, 14);
                        if (!array.Contains(count))
                        {
                            array[i] += count;
                            using (StreamWriter writer = new StreamWriter(filePath, true))
                            {
                                writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                            }
                            Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                        }
                        else
                        {
                            count = random.Next(0, 14);
                            if (!array.Contains(count))
                            {
                                array[i] += count;
                                using (StreamWriter writer = new StreamWriter(filePath, true))
                                {
                                    writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                                }
                                Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                            }
                            else
                            {
                                using (StreamWriter writer = new StreamWriter(filePath, true))
                                {
                                    writer.WriteLine($"Участник не нашёлся");
                                }
                                Console.WriteLine($"Участник не нашёлся");
                            }
                        }
                    }
                }
                students[count].employment = Employment.Учавствующий;
            }
            string[] inform = new string[array.Length + 1];
            string[] raffle = new string[1];
            raffle[0] = "Розыгрыша не будет, так пришла только одна группа";
            string[] counts = new string[1];
            for (int i = 0; array.Length > i; i++)
            {
                inform[i] = students[array[i]].group;
            }
            if (inform.Contains("321"))
            {
                if (inform.Contains("322"))
                {
                    counts[0] = $"В {events.time} пройдет розыгрыш на {events.draw}";
                    raffle = new string[array.Length + 1];

                    for (int i = 0; array.Length > i; i++)
                    {
                        raffle[i] += $"Участник: {students[array[i]].name}, группа: {students[array[i]].group}";
                    }
                    string[] result = counts.Concat(raffle).ToArray();
                    return result;
                }
                else
                {
                    return raffle;
                }
            }
            else
            {
                return raffle;
            }
        }
 
        public void Choice(List <Student> students)
        {
            Random random = new Random();
            for (int i = 0; students.Count > i; i++)
            {
                if(random.Next(0, 14) > 9)
                {
                    students[i].employment = Employment.Желающий;
                    Console.WriteLine($"Студент: {students[i].name} из {students[i].group} захотел стать желающим на следующие мероприятие");
                } 
            }
        }

        public string[] Listing_Students_Choice(Events events, List<Student> students, string filePath)
        {
            int[] array = new int[events.number_of_part];
            Random random = new Random((int)DateTime.Now.Ticks);
            int num = 0;
            for(int i = 0; students.Count > i; i++)
            {
                if (students[i].employment == Employment.Желающий)
                {
                    if(random.Next(0, 10) > 5)
                    {
                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            writer.WriteLine($"Участник: {students[i].name}, группа: {students[i].group}");
                        }
                        Console.WriteLine($"Участник: {students[i].name}, группа: {students[i].group}");
                        num++;
                    }
                }
            }
            for (int i = 0; i < events.number_of_part - num; i++)
            {
                int count = random.Next(0, 14);
                if (!array.Contains(count))
                {
                    array[i] += count;
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                    }
                    Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                }
                else
                {
                    count = random.Next(0, 14);
                    if (!array.Contains(count))
                    {
                        array[i] += count;
                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                        }
                        Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                    }
                    else
                    {
                        count = random.Next(0, 14);
                        if (!array.Contains(count))
                        {
                            array[i] += count;
                            using (StreamWriter writer = new StreamWriter(filePath, true))
                            {
                                writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                            }
                            Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                        }
                        else
                        {
                            count = random.Next(0, 14);
                            if (!array.Contains(count))
                            {
                                array[i] += count;
                                using (StreamWriter writer = new StreamWriter(filePath, true))
                                {
                                    writer.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                                }
                                Console.WriteLine($"Участник: {students[count].name}, группа: {students[count].group}");
                            }
                            else
                            {
                                using (StreamWriter writer = new StreamWriter(filePath, true))
                                {
                                    writer.WriteLine($"Участник не нашёлся");
                                }
                                Console.WriteLine($"Участник не нашёлся");
                            }
                        }
                    }
                }
                students[count].employment = Employment.Учавствующий;
            }
            string[] inform = new string[array.Length + 1];
            string[] raffle = new string[1];
            raffle[0] = "Розыгрыша не будет, так пришла только одна группа";
            string[] counts = new string[1];
            for (int i = 0; array.Length > i; i++)
            {
                inform[i] = students[array[i]].group;
            }
            if (inform.Contains("321"))
            {
                if (inform.Contains("322"))
                {
                    counts[0] = $"В {events.time} пройдет розыгрыш на {events.draw}";
                    raffle = new string[array.Length + 1];

                    for (int i = 0; array.Length > i; i++)
                    {
                        raffle[i] += $"Участник: {students[array[i]].name}, группа: {students[array[i]].group}";
                    }
                    string[] result = counts.Concat(raffle).ToArray();
                    return result;
                }
                else
                {
                    return raffle;
                }
            }
            else
            {
                return raffle;
            }
        }
    }
}
