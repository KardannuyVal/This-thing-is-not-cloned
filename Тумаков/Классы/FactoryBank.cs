using System;
using System.Collections;

namespace Тумаков
{
    internal class FactoryBank
    {
        private uint number = 0;
        private static Hashtable table = new Hashtable(10000);
        public Hashtable table_1 { get { return table; } }
        /// <summary>
        /// Перегруженный метод, который добавляет уникальный номер счёта в хеш таблицу
        /// </summary>
        /// <returns></returns>
        public uint CreateAccount()
        {
            number++;
            BankAccount bankAccount = new BankAccount();
            table.Add(number, bankAccount);
            Console.WriteLine($"Аккаунт банковского счёта с номером ({number}) добавлен, вы решили не класть деньги на баланс");
            return number;
        }
        /// <summary>
        /// Перегруженный метод, который добавляет уникальный номер счёта в хеш таблицу, а также позволяет положить на баланс деньги
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public uint CreateAccount(double money)
        {
            if (money < 0)
            {
                number++;
                Console.WriteLine($"Вы не можете положить отрицательно значение денежных средств на счет номер ({number})");
                BankAccount bankAccount = new BankAccount((double)0);
                table.Add(number, bankAccount);
                return number;
            }
            else
            {
                number++;
                Console.WriteLine($"Вы положили на счет номер ({number}) {money}");
                BankAccount bankAccount = new BankAccount(money);
                table.Add(number, bankAccount);
                return number;
            }
        }
        /// <summary>
        /// Метод, который удаляет из хеш таблицы номер счёта по его уникальному номеру
        /// </summary>
        /// <param name="number"></param>
        public void RemoveAccount(uint number)
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

        public void HashTable(uint[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (table.ContainsKey(numbers[i]))
                {
                    BankAccount account = table[numbers[i]] as BankAccount;
                    Console.WriteLine($"Аккаунт под номером {numbers[i]} на счёт которого {account.money} рублей был создан в " +
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
