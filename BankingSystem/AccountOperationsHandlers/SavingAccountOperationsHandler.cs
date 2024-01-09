using BankingSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.AccountOperationsHandlers
{
    public class SavingAccountOperationsHandler : AccountOperationsHandlerBase
    {
        public SavingAccountOperationsHandler(decimal balance): base(balance)
        {}
        
        public override string GetDescription()
        {
            return "This is a Saving account.";
        }

    }
}
