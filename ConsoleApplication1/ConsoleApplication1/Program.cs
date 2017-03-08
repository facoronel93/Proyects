using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
        string GetName();
    }
    public class CustomerAccount : IAccount
    {
        public CustomerAccount(
        string newName,
        decimal initialBalance)
        {
            name = newName;
            balance = initialBalance;
        }
        private decimal balance = 0;
        private string name;
        public virtual bool WithdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public string GetName()
        {
            return name;
        }
    }
}
