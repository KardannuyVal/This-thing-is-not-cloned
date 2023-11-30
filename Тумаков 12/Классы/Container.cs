using System;
using System.Collections.Generic;
using System.Linq;

namespace Тумаков_12
{
    internal class Container
    {
        /// <summary>
        /// Делегат
        /// </summary>
        /// <param name="books"></param>
        public delegate string[] BookDelegate(List<Book> books);
        /// <summary>
        /// Метод по сортированию книг по названию
        /// </summary>
        /// <param name="books"></param>
        public static string[] Sort_Name(List<Book> books)
        {
            string[] new_book = new string[0];
            foreach (Book book in books)
            {
                new_book = new_book.Append(book.name).ToArray();
            }
            Array.Sort(new_book);
            return new_book;
        }
        /// <summary>
        /// Метод по сортировке книг по автору
        /// </summary>
        /// <param name="books"></param>
        public static string[] Sort_Author(List<Book> books)
        {
            Console.WriteLine("Сортировка книг по автору");
            string[] new_book = new string[0];
            foreach (Book book in books)
            {
                new_book = new_book.Append(book.author).ToArray();
            }
            Array.Sort(new_book);
            return new_book;
        }
        /// <summary>
        /// Метод по сортировке книг по издательству
        /// </summary>
        /// <param name="books"></param>
        public static string[] Sort_Publishing(List<Book> books)
        {
            Console.WriteLine("Сортировка книг по издательству");
            string[] new_book = new string[0];
            foreach (Book book in books)
            {
                new_book = new_book.Append(book.publishing_house).ToArray();
            }
            Array.Sort(new_book);
            return new_book;    
        }

    }
}
