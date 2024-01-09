using BankingSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.AccountOperationsHandlers
{
    public class FixedDepositAccountOperationsHandler: AccountOperationsHandlerBase
    {
        private readonly int _age;
        public FixedDepositAccountOperationsHandler(decimal balance, int age):base(balance)
        {
            _age = age;
        }
        public override void Withdraw(decimal amount)
        {
            if (_age < 18)
            {
                throw new InvalidOperationException(message: "Non Mature Withdraw try.");
            }
            base.Withdraw(amount);
        }
        public override string GetDescription()
        {
            return "This is a Fixed Deposit account.";
        }
        
    }
}
