using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Library
{
    public class FactoryBank_1
    {
        private uint number = 0;
        private static Hashtable table = new Hashtable(10000);
        public Hashtable table_1 { get { return table; } }
        /// <summary>
        /// Перегруженный метод, который добавляет уникальный номер счёта в словарь
        /// </summary>
        /// <returns></returns>
        public uint CreateAccount_1()
        {
            number++;
            BankAccount_1 bankAccount = new BankAccount_1();
            table.Add(number, bankAccount);
            Console.WriteLine($"Аккаунт банковского счёта с номером ({number}) добавлен, вы решили не класть деньги на баланс");
            return number;
        }
        /// <summary>
        /// Перегруженный метод, который добавляет уникальный номер счёта в словарь, а также позволяет положить на баланс деньги
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public uint CreateAccount_1(double money)
        {
            if (money < 0)
            {
                number++;
                Console.WriteLine($"Вы не можете положить отрицательно значение денежных средств на счет номер ({number})");
                BankAccount_1 bankAccount = new BankAccount_1((double)0);
                table.Add(number, bankAccount);
                return number;
            }
            else
            {
                number++;
                Console.WriteLine($"Вы положили на счет номер ({number}) {money}");
                BankAccount_1 bankAccount = new BankAccount_1(money);
                table.Add(number, bankAccount);
                return number;
            }
        }
        /// <summary>
        /// Метод, который удаляет из словаря номер счёта по его уникальному номеру
        /// </summary>
        /// <param name="number"></param>
        public void RemoveAccount_1(uint number)
        {
            if (table.ContainsKey(number))
            {
                Console.WriteLine($"Аккаунт банковского счета с номером {number} удалён");
                table.Remove(number);
            }
            else
            {
                Console.WriteLine("Данного номера не существует");
            }
        }
        /// <summary>
        /// Хеш-таблица
        /// </summary>
        /// <param name="numbers"></param>

        public void HashTable_1(uint[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (table.ContainsKey(numbers[i]))
                {
                    BankAccount_1 account = table[numbers[i]] as BankAccount_1;
                    Console.WriteLine($"Аккаунт под номером {numbers[i]} на счёт которого {account.money_1} рублей был создан в " +
                        $"{DateTime.Now}");
                }
                else
                {
                    Console.WriteLine($"Аккаунт под номером {numbers[i]} не найден ");
                }
            }
        }
    }
}
