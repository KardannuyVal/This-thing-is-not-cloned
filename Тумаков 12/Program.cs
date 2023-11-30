using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Тумаков_12.Container;

namespace Тумаков_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Упражнение 12.1");
            Console.WriteLine("Переопределение операторов и методов");
            Bank_account bank_1 = new Bank_account("Сбербанк", 123456, 10000);
            Bank_account bank_2 = new Bank_account("Тинькофф", 123456, 20000);
            Bank_account bank_3 = new Bank_account("Сбербанк", 234567, 30000);
            bank_1.GetBalance(20000);
            bank_2.GetBalance(10000);
            bank_3.GetBalance(-1000);
            Console.WriteLine("Сравним названия 1 и 3 счёта");
            if (bank_1.Equals(bank_3) == true)
            {
                Console.WriteLine($"Счёта имеют одинаковое название {bank_1}");
            }
            else
            {
                Console.WriteLine("Счета имеют разное название");
            }
            Console.WriteLine("Сравним название 1 и 2 счёта");
            Console.WriteLine();
            if (bank_1.Equals(bank_2) == true)
            {
                Console.WriteLine("Счёта имеют одинаковое название");
            }
            else
            {
                Console.WriteLine("Счета имеют разное название");
            }

            Bank_account bank_4 = new Bank_account(10000);
            Bank_account bank_5 = new Bank_account(20000);
            Bank_account bank_6 = new Bank_account(10000);
            Console.WriteLine("Проверим баланс 4 и 6 счёта");
            if ((bank_4 == bank_6))
            {
                Console.WriteLine("Имеют одинаковый баланс");
            }
            else
            {
                Console.WriteLine("Имеют разный баланс");
            }
            Console.WriteLine();
            Console.WriteLine("Проверим баланс 4 и 5 счёта");
            if ((bank_4 == bank_5) == true)
            {
                Console.WriteLine("Имеют одинаковый баланс");
            }
            else
            {
                Console.WriteLine("Имеют разный баланс");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            Console.WriteLine();
            
            Console.WriteLine("Упражнение 12.2");
            Console.WriteLine("Работа с рациональными числами");
            Rational_numbers number_1 = new Rational_numbers(10, 100);
            Rational_numbers number_2 = new Rational_numbers(5, 2);
            Rational_numbers number_3 = number_1 + number_2;
            Rational_numbers number_4 = number_1 - number_2;
            Rational_numbers number_5 = number_1 * number_2;
            Rational_numbers number_6 = number_1 / number_2;
            Rational_numbers number_7 = number_1 % number_2;
            Rational_numbers number_8 = new Rational_numbers(10, 3);
            Rational_numbers number_9 = new Rational_numbers(10, 2);
            Console.WriteLine("\nПроверим операции");
            Console.WriteLine($"проверим числa ({number_1}) и ({number_2}) на равенство, РЕЗУЛЬТАТ: {number_1 == number_2}");
            Console.WriteLine($"проверим числa ({number_1}) и ({number_2}) на неравенство, РЕЗУЛЬТАТ: {number_1 != number_2}");
            Console.WriteLine($"проверим числa ({number_1}) и ({number_2}) на <, РЕЗУЛЬТАТ: {number_1 < number_2}");
            Console.WriteLine($"проверим числa ({number_1}) и ({number_2}) на >, РЕЗУЛЬТАТ: {number_1 > number_2}");
            Console.WriteLine($"проверим числa ({number_1}) и ({number_2}) на <=, РЕЗУЛЬТАТ: {number_1 <= number_2}");
            Console.WriteLine($"проверим числa ({number_1}) и ({number_2}) на >=, РЕЗУЛЬТАТ: {number_1 >= number_2}");
            Console.WriteLine($"{number_1} + {number_2} = {number_3}");
            Console.WriteLine($"{number_1} - {number_2} = {number_4}");
            Console.WriteLine($"{number_1} * {number_2} = {number_5}");
            Console.WriteLine($"{number_1} / {number_2} = {number_6}");
            Console.WriteLine($"{number_1} % {number_2} = {number_7}");
            Console.WriteLine($"{number_8++} операция ++, РЕЗУЛЬТАТ: {number_8}");
            Console.WriteLine($"{number_9--} операция --, РЕЗУЛЬТАТ: {number_9}");
            Console.WriteLine($"приведем дробь {number_2} к типу int, РЕЗУЛЬТАТ: {(int)number_2}");
            Console.WriteLine($"приведем дробь {number_2} к типу float, РЕЗУЛЬТАТ: {(float)number_2}");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine();

            Console.WriteLine("Домашнее задание 12.1");
            Console.WriteLine("Комплексные числа");
            Complex_number number__1 = new Complex_number(2, 3);
            Complex_number number__2 = new Complex_number(3, 4);
            double count = 10;
            Console.WriteLine("Проведем операции над комплексными числами");
            Console.WriteLine($"Первое комплексное число: {number__1}");
            Console.WriteLine($"Второе комплексное число: {number__2}");
            Complex_number number__3 = number__1 + number__2;
            Complex_number number__4 = number__1 - number__2;
            Complex_number number__5 = number__1 * number__2;
            Complex_number number__6 = number__1 + count;
            Complex_number number__7 = number__1 - count;
            Complex_number number__8 = number__1 * count;
            Console.WriteLine($"({number__1}) + ({number__2}) = ({number__3})");
            Console.WriteLine($"({number__1}) - ({number__2}) = ({number__4})");
            Console.WriteLine($"({number__1}) * ({number__2}) = ({number__5})");
            Console.WriteLine($"({number__1}) + ({count}) = ({number__6})");
            Console.WriteLine($"({number__1}) - ({count}) = ({number__7})");
            Console.WriteLine($"({number__1}) * ({count}) = ({number__8})");
            Console.WriteLine($"Сравним на ({number__1}) и ({number__2}) на равенство, РЕЗУЛЬТАТ: {number__1 == number__2}");
            Console.WriteLine($"Сравним на ({number__1}) и ({number__2}) на неравенство, РЕЗУЛЬТАТ: {number__1 != number__2}");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            Console.WriteLine();
            
            Console.WriteLine("Домашнее задание 12.2");
            Console.WriteLine("Сортировка книг");
            Book book_1 = new Book("Стрела", "Пушкин", "Москва_фабрика");
            Book book_2 = new Book("Дятел", "Лермонтов", "Питер_фабрика");
            Book book_3 = new Book("Ведьмак", "Карамзин", "Казань_фабрика");
            Book book_4 = new Book("Недоносок", "Тютчев", "Ижевск_фабрика");
            Book book_5 = new Book("Отморозок", "Шолохов", "Уфа_фабрика");
            List<Book>books = new List<Book> { book_1, book_2, book_3, book_4, book_5 };
            
            BookDelegate bookDelegate_1 = Sort_Name;
            Console.WriteLine("Сортировка по названию книги");
            Console.WriteLine();
            string[] arr_name = bookDelegate_1(books);
            foreach (string book_name in arr_name)
            {
                Console.WriteLine(book_name);
            }
            BookDelegate bookDelegate_2 = Sort_Author;
            Console.WriteLine();

            Console.WriteLine("Сортировка по автору");
            Console.WriteLine();
            string[] arr_author = bookDelegate_2(books);
            foreach(string book_author in arr_author)
            {
                Console.WriteLine(book_author);
            }
            BookDelegate bookDelegate_3 = Sort_Publishing;
            Console.WriteLine();

            Console.WriteLine("Сортировка по издательству");
            string[] arr_publishing = bookDelegate_3(books);
            foreach(string book_publishing in arr_publishing)
            {
                Console.WriteLine(book_publishing); 
            }
            Console.WriteLine();

            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
            
        }
    }
}
