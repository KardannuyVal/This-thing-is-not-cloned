using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Library
{
    public class BankAccount_1
    {
        private int account_number_1 { get; set; }
        internal double money_1 { get; set; }
        internal BankAccount_1(double money_1)
        {
            this.money_1 = money_1;
        }
        internal BankAccount_1() { }
    }
}
