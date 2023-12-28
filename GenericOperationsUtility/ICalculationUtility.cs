using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOperationsUtility
{
    public interface ICalculationUtility<T>
    {
        T Add(T arg1, T arg2);
        T Subtract(T arg1, T arg2);
        T Multiply(T arg1, T arg2);
        T Divide(T dividend, T divisor, out T quotient);
        void QuotientAndRemainder(T dividend, T divisor, out T quotient, out T remainder);
    }
}
