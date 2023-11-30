using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_Labrary
{
    public enum Color
    {
        черный = 1,
        белый = 2,
        синий = 3,
        зеленый = 4
    }
    public class Apartment_1
    {
        internal static int number_1;//уникальный номер квартиры
        internal uint height_1;// высота здания
        internal uint floor_1;//количество этажей
        internal double heig_floor_1;
        internal Color color_1;
        internal Apartment_1(uint height, uint floor, Color color)
        {
            this.height_1 = height;
            this.floor_1 = floor;
            this.color_1 = color;
        }
        internal Apartment_1(uint height, uint floor)
        {
            this.height_1 = height;
            this.floor_1 = floor;
        }
    }
}
