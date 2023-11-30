using System;

namespace Тумаков_12
{
    internal class Bank_account
    {
        private string name { get; set; }
        private int number = 1;
        public double balance { get; set; }
        public Bank_account(string name, int number, double balance)
        {
            this.name = name;
            this.number = number;
            this.balance = balance;
        }
        public Bank_account(double balance)
        {
            this.balance = balance;
        }
        /// <summary>
        /// Метод, который позволяет положить на счёт деньги
        /// </summary>
        /// <param name="money"></param>
        public void GetBalance(double money)
        {
            if (money < 0)
            {
                Console.WriteLine("Вы не можете положить на счёт отрицательную сумму");
            }
            else
            {
                balance += money;
                Console.WriteLine($"На вашем счёте <{number}> {balance}");
            }
        }
        /// <summary>
        /// Переопределённый метод ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name;
        }
        /// <summary>
        /// Переопределённый метод Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (GetType() != obj.GetType())
            {
                return false;
            }
            Bank_account other = (Bank_account)obj;
            if (other == null)
            {
                return false;
            }
            return name == other.name;
            //return name.Equals(other.name);
        }
        /// <summary>
        /// Переопределённый метод GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        /// <summary>
        /// Переопределённый метод ==
        /// </summary>
        /// <param name="bank_1"></param>
        /// <param name="bank_2"></param>
        /// <returns></returns>
        
        public static bool operator ==(Bank_account bank_1, Bank_account bank_2)
        {
            if(bank_1 is null || bank_2 is null)
            {
                return false;
            }
            if(bank_1.balance != bank_2.balance)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Переопределённый метод !=
        /// </summary>
        /// <param name="bank_1"></param>
        /// <param name="bank_2"></param>
        /// <returns></returns>
        public static bool operator !=(Bank_account bank_1, Bank_account bank_2)
        {
            return !(bank_1 == bank_2);
        }
        /// <summary>
        /// Метод, который показывает информацию о имени счёта
        /// </summary>
        /// <param name="bank_account"></param>
        public void Information(Bank_account bank_account)
        {
            if(name.Equals(bank_account.name) == true)
            {
                Console.WriteLine($"Два счёта одинаковое название {name}");
            }
            else
            {
                Console.WriteLine("Имеют разные названия");
            }
        }
        
    }
}
