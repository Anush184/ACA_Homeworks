using BankingSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.AccountOperationsHandlers
{
    public abstract class AccountOperationsHandlerBase:IAccountOperationsHandler
    {
        protected decimal _balance;
        public AccountOperationsHandlerBase(decimal balance)
        {
            _balance = balance; 
        }
        public virtual void Deposit(decimal amount)
        {
            _balance += amount;
        }
        public virtual void Withdraw(decimal amount)
        {
            _balance -= amount;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public abstract string GetDescription();
               
    }
}
