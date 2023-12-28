using BankingSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class CheckingAccount : IAccount
    {
        private IAccount account;
        private decimal overdraftLimit;
        public CheckingAccount(IAccount account, decimal overdraftLimit)
        {
            this.account = account;
            this.overdraftLimit = overdraftLimit;
        }
        public void Deposit(decimal amount)
        {
            account.Deposit(amount);
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Checking Account Information:");
            account.DisplayAccountDetails();
            Console.WriteLine($"Overdraft Limit: ${overdraftLimit}");
        }

        public decimal GetAccountBalance()
        {
            return account.GetAccountBalance();
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= account.GetAccountBalance() + overdraftLimit)
            {
                account.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Exceeded overdraft limit.");
            }
        }
    }
}
