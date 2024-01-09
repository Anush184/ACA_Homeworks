using BankingSystem.Common.Enums;
using BankingSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Account 
    {
        private readonly IAccountOperationsHandler _operationsHandler;
        private readonly IDataIntegrator _integrator;
        public Account(IAccountOperationsHandler operationsHandler, IDataIntegrator dataIntegrator)
        {
            _operationsHandler = operationsHandler; 
            _integrator = dataIntegrator;
        }
        public void Deposit(decimal amount)
        {
            _operationsHandler.Deposit(amount);
            _integrator.Write(content: $"Deposit from account with amount {amount}, current balance {_operationsHandler.GetBalance()}");
        }

        public void Withdraw(decimal amount)
        {
           _operationsHandler.Withdraw(amount);
            _integrator.Write(content: $"Withdraw from account with amount {amount}, current balance {_operationsHandler.GetBalance()}");

        }

        public decimal GetBalance()
        {
            return _operationsHandler.GetBalance();
        }

        public string GetDescription()
        {
            return _operationsHandler.GetDescription();   
        }
        
    }
}
