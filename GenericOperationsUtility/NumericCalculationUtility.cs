using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOperationsUtility
{
    public class NumericCalculationUtility : ICalculationUtility<int>, ICalculationUtility<double>
    {
        public int Add(int operand1, int operand2) => operand1 + operand2;
        public int Subtract(int operand1, int operand2) => operand1 - operand2;
        public int Multiply(int operand1, int operand2) => operand1 * operand2;
        public int Divide(int dividend, int divisor, out int quotient)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            quotient = dividend / divisor;
            return quotient;
        }

        public void QuotientAndRemainder(int dividend, int divisor, out int quotient, out int remainder)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        // Implementation for double (floating-point) operations

        public double Add(double operand1, double operand2) => operand1 + operand2;
        public double Subtract(double operand1, double operand2) => operand1 - operand2;
        public double Multiply(double operand1, double operand2) => operand1 * operand2;

        public double Divide(double dividend, double divisor, out double quotient)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            quotient = dividend / divisor;
            return quotient;
        }

        public void QuotientAndRemainder(double dividend, double divisor, out double quotient, out double remainder)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }


    }
}
