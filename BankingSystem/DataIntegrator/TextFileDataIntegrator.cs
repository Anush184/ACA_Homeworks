using BankingSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataIntegrator
{
    public class TextFileDataIntegrator : IDataIntegrator
    {
        private readonly string _path;
        public TextFileDataIntegrator()
        {
            _path = "C:/Users/anave/Desktop/TransactionHistory.txt";
        }

        public string Read()
        {
            string result;
            using(var sr = new StreamReader(_path)) 
            {
                result = sr.ReadToEnd();
            }
            return result;

        }

        public void Write(string content)
        {
            using (StreamWriter sm = new StreamWriter(_path, append: true))
            {
                sm.WriteLine(content);
            }
        }

    }
}
