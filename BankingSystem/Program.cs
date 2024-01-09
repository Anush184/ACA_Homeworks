using BankingSystem;
using BankingSystem.AccountOperationsHandlers;
using BankingSystem.Common;
using BankingSystem.Common.Enums;
using BankingSystem.Contracts;
using BankingSystem.DataIntegrator;

Console.OutputEncoding = System.Text.Encoding.UTF8;
var savingAccount = new Account(new SavingAccountOperationsHandler(balance: 100), new TextFileDataIntegrator());
savingAccount.Deposit(amount: 10);
savingAccount.Withdraw(amount: 20);


var checkingAccount = new Account(new CheckingAccountOperationsHandler(balance: 100, overdraftLimit:20), new TextFileDataIntegrator());
checkingAccount.Deposit(amount: 10);
checkingAccount.Withdraw(amount: 20);


var fixedDepositAccount = new Account(new FixedDepositAccountOperationsHandler(balance: 100,age:20), new TextFileDataIntegrator());
fixedDepositAccount.Deposit(amount: 10);
fixedDepositAccount.Withdraw(amount: 20);
