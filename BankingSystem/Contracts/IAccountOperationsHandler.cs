using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Contracts
{
    public interface IAccountOperationsHandler
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal GetBalance();
        string GetDescription();
    }
}
