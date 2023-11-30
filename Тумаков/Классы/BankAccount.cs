
namespace Тумаков
{
    internal class BankAccount
    {
        private int account_number { get; set; }
        internal double money { get; set; }
        internal BankAccount(double money) 
        {
            this.money = money;
        }
        internal BankAccount() { }
    }
}
