using BankingSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class FixedDepositAccount : IAccount
    {
        private IAccount account;
        private DateTime maturityDate;

        public FixedDepositAccount(IAccount account, DateTime maturityDate)
        {
            this.account = account;
            this.maturityDate = maturityDate;
        }
        public void Deposit(decimal amount)
        {
            account.Deposit(amount);
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Fixed Deposit Account Information:");
            account.DisplayAccountDetails();
            Console.WriteLine($"Maturity Date: {maturityDate.ToShortDateString()}");
        }

        public decimal GetAccountBalance()
        {
            return account.GetAccountBalance();
        }

        public void Withdraw(decimal amount)
        {
            if (maturityDate >= DateTime.Now)
            {
                Console.WriteLine("Withdrawals are not allowed until maturity.");
            }
            else
            {
                account.Withdraw(amount);
            }
        }
    }
}
