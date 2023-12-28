using BankingSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class SavingsAccount : IAccount
    {
        private IAccount account;
        private decimal interestRate;
        public SavingsAccount(IAccount account, decimal interestRate)
        {
            this.account = account;
            this.interestRate = interestRate;
        }
        public void Deposit(decimal amount)
        {
            account.Deposit(amount);
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Savings Account Information:");
            account.DisplayAccountDetails();
            Console.WriteLine($"Interest Rate: {interestRate:P}");
        }

        public decimal GetAccountBalance()
        {
            return account.GetAccountBalance();
        }

        public void Withdraw(decimal amount)
        {
            account.Withdraw(amount);
        }

        public void CalculateInterest()
        {
            decimal interestAmount = account.GetAccountBalance() * interestRate;
            account.Deposit(interestAmount);
            Console.WriteLine($"Interest calculated: ${interestAmount}");
        }
    }
}
