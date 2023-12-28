using BankingSystem.Common.Enums;
using BankingSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Account : IAccount
    {
        private string accountNumber;
        private string accountHolder;
        private decimal balance;
        private CurrencyType currency;
        private DateTime openDate;
        private DateTime? closingDate;


        public Account(string accountNumber, string accountHolder, decimal initialBalance, CurrencyType currency, DateTime openDate, DateTime? closingDate)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = initialBalance;
            this.currency = currency;
            this.openDate = openDate;
            this.closingDate = closingDate;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {FormatAmount(amount, currency)}. New balance: {FormatAmount(balance, currency)}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {FormatAmount(amount, currency)}. New balance: {FormatAmount(balance, currency)}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public decimal GetAccountBalance()
        {
            return balance;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder: {accountHolder}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"Currency: {currency}");
            Console.WriteLine($"OpenDate: {openDate}");
            Console.WriteLine($"ClosingDate: {closingDate}");
        }

        private string FormatAmount(decimal amount, CurrencyType currency)
        {
            switch (currency)
            {
                case CurrencyType.USD:
                    return $"${amount}";
                case CurrencyType.EUR:
                    return $"€{amount}";
                case CurrencyType.AMD:
                    return $"{amount} ֏";
                case CurrencyType.RUB:
                    return $"{amount} ₽";
                default:
                    return $"{amount} {currency}";
            }
        }
    }
}
