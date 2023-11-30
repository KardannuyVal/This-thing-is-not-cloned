using System;
using Bank_Library;
using Apartment_Labrary;

namespace Тумаков
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Упражнение 11.1");
            Console.WriteLine("Программа с фабрикой классов для банковского счёта");
            Console.WriteLine("\nСоздадим аккаунт");
            FactoryBank factoryBank = new FactoryBank();
            uint number_1 = factoryBank.CreateAccount(100);
            uint number_2 = factoryBank.CreateAccount(10000);
            uint number_3 = factoryBank.CreateAccount(-1000);
            factoryBank.RemoveAccount(number_1);
            uint[] numbers_1 = new uint[] { number_1, number_2, number_3};
            Console.WriteLine();
            factoryBank.HashTable(numbers_1);
            Console.WriteLine("\nДля того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            Console.WriteLine();

            Console.WriteLine("Упражнение 11.2");
            Console.WriteLine("Разбить классы связанные с банковским счётом (DLL)");
            FactoryBank_1 factoryBank_1 = new FactoryBank_1();
            uint number__1 = factoryBank_1.CreateAccount_1(1000);
            uint number__2 = factoryBank_1.CreateAccount_1(100000);
            uint number__3 = factoryBank_1.CreateAccount_1(-10000);
            factoryBank_1.RemoveAccount_1(number_1);
            uint[] numbers___1 = new uint[] { number__1, number__2, number__3 };
            Console.WriteLine();
            factoryBank_1.HashTable_1(numbers_1);

            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            Console.WriteLine();
            
            Console.WriteLine("Домашнее задание 11.1");
            Console.WriteLine("Программа с фабрикой класса для здания");
            uint number___1 = Creator.CreateBuild(10, 5);
            uint number___2 = Creator.CreateBuild(30, 15);
            uint number___3 = Creator.CreateBuild(100, 30, Color.черный);
            uint[] numbers____1 = new uint[] { number___1, number___2, number___3 };
            Creator.RemoveApartment(number___1);
            Console.WriteLine();
            Creator.Hash_Table(numbers____1);
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            Console.WriteLine();

            Console.WriteLine("Домашнее задание 11.2");
            Console.WriteLine("Разбить классы связанные с квартирами (DLL)");
            uint number____1 = Creator_1.CreateBuild_1(10, 5);
            uint number____2 = Creator_1.CreateBuild_1(30, 15);
            uint number____3 = Creator_1.CreateBuild_1(100, 30, (Apartment_Labrary.Color)Color.синий);
            uint[] numbers_____1 = new uint[] { number____1, number____2, number____3 };
            Creator_1.RemoveApartment_1(number____1);
            Console.WriteLine();
            Creator_1.Hash_Table_1(numbers_____1);

            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();


        }

    }
}
