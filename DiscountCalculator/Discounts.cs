using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCardDiscountCalculator
{

    public delegate double DiscountCalculator(double totalAmount);
    public class Discounts
    {
        public static decimal RegularCustomerDiscount(decimal amount)
        {
            return amount - amount * 0.1m;
        }
        public static double RegularCustomerDiscount(double totalAmount)
        {
            double discountPercentage = 5.0;
            return totalAmount - (totalAmount * discountPercentage / 100);
        }

        public static double VIPCustomerDiscount(double totalAmount)
        {
            double discountPercentage = 20.0;
            return totalAmount - (totalAmount * discountPercentage / 100);
        }

        public static double SaleDiscount(double totalAmount)
        {
            double discountPercentage = 25.0;
            return totalAmount - (totalAmount * discountPercentage / 100);
        }

    }
}
