using BankingSystem;
using BankingSystem.Common;
using BankingSystem.Common.Enums;
using BankingSystem.Contracts;

Console.OutputEncoding = System.Text.Encoding.UTF8;
IAccount basicAccount = new Account("123", "John Doe", 1000, CurrencyType.EUR, DateTime.Parse("2020-11-01"), DateTime.Parse("2029-12-20"));

IAccount checkingAccount = new CheckingAccount(basicAccount, 500);

IAccount savingsAccount = new SavingsAccount(basicAccount, 0.03m);

IAccount fixedDepositAccount = new FixedDepositAccount(savingsAccount, DateTime.Now.AddYears(1));

//IAccount fixedDepositAccount2 = new FixedDepositAccount(savingsAccount, DateTime.Parse("2022-11-01"));
//checkingAccount.Deposit(200);
//checkingAccount.Withdraw(800);

//savingsAccount.Deposit(500);
//savingsAccount.Withdraw(200);
//((SavingsAccount)savingsAccount).CalculateInterest();

fixedDepositAccount.Deposit(1000);
fixedDepositAccount.Withdraw(500);


Console.WriteLine("\nAccount Information:");
//basicAccount.DisplayAccountDetails();
//checkingAccount.DisplayAccountDetails();
//savingsAccount.DisplayAccountDetails();
fixedDepositAccount.DisplayAccountDetails();
