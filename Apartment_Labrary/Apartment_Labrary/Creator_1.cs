using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_Labrary
{
    public class Creator_1
    {
        private static uint number_1 = 0;
        private static Hashtable table_1 = new Hashtable(10000);
        public Hashtable Table_1 { get { return table_1; } }
        /// <summary>
        /// Перегруженный метод для вычисления высоты этажа. Метод добавляет уникальный номер здания в словарь
        /// </summary>
        /// <param name="heigth"></param>
        /// <param name="floor"></param>
        /// <returns></returns>
        public static uint CreateBuild_1(uint heigth, uint floor)
        {
            number_1++;
            Apartment_1 apartments = new Apartment_1(heigth, floor);
            table_1.Add(number_1, apartments);
            apartments.heig_floor_1 = heigth / floor;
            return number_1;
        }
        /// <summary>
        /// Перегруженный метод вычисления высоты этажа и определения цвета здания. Метод добавляет уникальный номер здания в словарь
        /// </summary>
        /// <param name="heigth"></param>
        /// <param name="floor"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static uint CreateBuild_1(uint heigth, uint floor, Color color)
        {
            number_1++;
            Apartment_1 apartments = new Apartment_1(heigth, floor);
            table_1.Add(number_1, apartments);
            apartments.heig_floor_1 = heigth / floor;
            apartments.color_1 = color;
            return number_1;
        }
        /// <summary>
        /// Метод, который удаляет уникальный номер здания по его уникального номера
        /// </summary>
        /// <param name="number"></param>
        public static void RemoveApartment_1(uint number)
        {
            if (table_1.ContainsKey(number))
            {
                Console.WriteLine($"Квартира с уникальным номером {number} была удалена");
                table_1.Remove(number);
            }
            else
            {
                Console.WriteLine("Данной квартиры не существует");
            }
        }
        /// <summary>
        /// хеш-таблица
        /// </summary>
        /// <param name="numbers"></param>
        public static void Hash_Table_1(uint[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (table_1.ContainsKey(numbers[i]))
                {
                    Apartment_1 apartment = table_1[numbers[i]] as Apartment_1;
                    if (apartment.color_1 != 0)
                    {
                        Console.WriteLine($"Квартира под номер {numbers[i]}, высота одного этажа: {apartment.heig_floor_1} метров, цвет: {apartment.color_1}");
                    }
                    else
                    {
                        Console.WriteLine($"Квартира под номер {numbers[i]}, высота одного этажа: {apartment.heig_floor_1} метров, цвет: вы не выбрали");
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
