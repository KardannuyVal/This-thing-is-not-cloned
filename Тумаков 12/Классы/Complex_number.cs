
namespace Тумаков_12
{
    internal class Complex_number
    {
        private double real_number;
        private double complex_number;
        public Complex_number(double real_number, double complex_number)
        {
            this.real_number = real_number;
            this.complex_number = complex_number;
        }
        /// <summary>
        /// Переопределённый метод Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Complex_number number)
            {
                if (real_number == number.real_number && complex_number == number.complex_number)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        /// <summary>
        /// Переопределённый метод GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        /// Перегруженные операторы +
        /// </summary>
        /// <param name="number_1"></param>
        /// <param name="number_2"></param>
        /// <returns></returns>

        public static Complex_number operator +(Complex_number number_1, Complex_number number_2)
        {
            return new Complex_number(number_1.real_number + number_2.real_number, number_1.complex_number + number_2.complex_number);
        }
        public static Complex_number operator +(Complex_number number_1, double number_2)
        {
            return new Complex_number(number_1.real_number + number_2, number_1.complex_number);
        }

        /// <summary>
        /// Перегруженные операторы -
        /// </summary>
        /// <param name="number_1"></param>
        /// <param name="number_2"></param>
        /// <returns></returns>
        public static Complex_number operator -(Complex_number number_1, Complex_number number_2)
        {
            return new Complex_number(number_1.real_number - number_2.real_number, number_1.complex_number - number_2.complex_number);
        }
        public static Complex_number operator -(Complex_number number_1, double number_2)
        {
            return new Complex_number(number_1.real_number - number_2, number_1.complex_number);
        }

        /// <summary>
        /// Перегруженные операторы *
        /// </summary>
        /// <param name="number_1"></param>
        /// <param name="number_2"></param>
        /// <returns></returns>
        public static Complex_number operator *(Complex_number number_1, Complex_number number_2)
        {
            return new Complex_number((number_1.real_number * number_2.real_number) - (number_1.complex_number * number_2.complex_number),
                number_1.real_number * number_2.complex_number + number_1.complex_number * number_2.real_number);
        }
        public static Complex_number operator *(Complex_number number_1, double number_2)
        {
            return new Complex_number(number_1.real_number * number_2, number_1.complex_number * number_2);
        }

        /// <summary>
        /// Переопределённый метод оператор ==
        /// </summary>
        /// <param name="number_1"></param>
        /// <param name="number_2"></param>
        /// <returns></returns>
        public static bool operator ==(Complex_number number_1, Complex_number number_2)
        {
            return ((number_1.real_number == number_2.real_number) && (number_1.complex_number == number_2.complex_number));
        }
        /// <summary>
        /// Переопределённый оператор !=
        /// </summary>
        /// <param name="number_1"></param>
        /// <param name="number_2"></param>
        /// <returns></returns>
        public static bool operator !=(Complex_number number_1, Complex_number number_2)
        {
            return !((number_1.real_number == number_2.real_number) && (number_1.complex_number == number_2.complex_number));
        }
        /// <summary>
        /// Переопределённый метод ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{real_number} + {complex_number}i";
        }
        
    }
}
