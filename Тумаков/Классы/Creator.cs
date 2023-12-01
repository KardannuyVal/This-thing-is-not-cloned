using System;
using System.Collections;

namespace Тумаков
{
    internal class Creator
    {
        private static uint number = 0;
        private static Hashtable table = new Hashtable(10000);
        public Hashtable Table { get { return table; } }
        public static uint CreateBuild(uint heigth, uint floor)
        {
            number++;
            Apartment apartments = new Apartment(heigth, floor);
            table.Add(number, apartments);
            apartments.heig_floor = heigth / floor;
            return number;
        }
        public static uint CreateBuild(uint heigth, uint floor, Color color)
        {
            number++;
            Apartment apartments = new Apartment(heigth, floor);
            table.Add(number, apartments);
            apartments.heig_floor = heigth / floor;
            apartments.color = color;
            return number;
        }
        public static void RemoveApartment(uint number)
        {
            if (table.ContainsKey(number))
            {
                Console.WriteLine($"Квартира с уникальным номером {number} была удалена");
                table.Remove(number);
            }
            else
            {
                Console.WriteLine("Данной квартиры не существует");
            }
        }
        public static void Hash_Table(uint[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (table.ContainsKey(numbers[i]))
                {
                    Apartment apartment = table[numbers[i]] as Apartment;
                    if (apartment.color != 0)
                    {
                        Console.WriteLine($"Квартира под номер {numbers[i]}, высота одного этажа: {apartment.heig_floor} метров, цвет: {apartment.color}");
                    }
                    else
                    {
                        Console.WriteLine($"Квартира под номер {numbers[i]}, высота одного этажа: {apartment.heig_floor} метров, цвет: вы не выбрали");
                    }
                }
                else
                {
                    Console.WriteLine($"Квартира под номером: {numbers[i]} было удалено");
                }
            }
        }
    }
}
