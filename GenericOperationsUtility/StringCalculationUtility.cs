using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOperationsUtility
{
    public class StringCalculationUtility : ICalculationUtility<string>
    {
        public string Add(string arg1, string arg2)
        {
            return arg1 + arg2;
        }

        public string Divide(string dividend, string divisor, out string quotient)
        {
            throw new NotSupportedException("Division is not supported for strings.");
        }

        public string Multiply(string arg1, string arg2)
        {
            throw new NotSupportedException("Multiplication is not supported for strings.");
        }

        public void QuotientAndRemainder(string dividend, string divisor, out string quotient, out string remainder)
        {
            throw new NotSupportedException("Quotient and remainder are not supported for strings.");
        }

        public string Subtract(string arg1, string arg2)
        {
            throw new NotSupportedException("Subtraction is not supported for strings.");
        }

    }
}
