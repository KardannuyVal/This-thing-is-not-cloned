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
        public override string ToString()
        {
            return name;
        }
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
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        
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

        public static bool operator !=(Bank_account bank_1, Bank_account bank_2)
        {
            return !(bank_1 == bank_2);
        }
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
