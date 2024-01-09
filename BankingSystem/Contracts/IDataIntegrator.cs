using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Contracts
{
    public interface IDataIntegrator
    {
        void Write(string content);
        string Read();
    }
}
