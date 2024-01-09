using BankingSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.AccountOperationsHandlers
{
    public class CheckingAccountOperationsHandler: AccountOperationsHandlerBase
    {
        private readonly decimal _overdraftLimit;
        public CheckingAccountOperationsHandler(decimal balance, decimal overdraftLimit):base(balance)
        {
           _overdraftLimit = overdraftLimit;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount - _balance > _overdraftLimit)
            {
                throw new InvalidOperationException(message: "Overdraft limit exceeded.");
            }
            base.Withdraw(amount);
        }
        public override string GetDescription()
        {
            return "This is a Chacking account.";
        }

       
    }
}
