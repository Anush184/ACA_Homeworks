using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBuilderExample
{
    delegate decimal DiscountCalculator(decimal totalAmount);
    class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public ShoppingCart AddProduct(Product product)
        {
            products.Add(product);
            return this;
        }

        public Order.OrderBuilder Checkout(DiscountCalculator discountCalculator)
        {
            decimal totalAmount = CalculateTotalAmount();
            decimal discountedAmount = discountCalculator(totalAmount);

            Console.WriteLine($"Total Amount: {totalAmount:C}");
            Console.WriteLine($"Discounted Amount: {discountedAmount:C}");

            Order.OrderBuilder orderBuilder = new Order.OrderBuilder();
            foreach (var product in products)
            {
                orderBuilder.AddProduct(product);
            }

            return orderBuilder;
        }

        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (var product in products)
            {
                totalAmount += product.Price;
            }
            return totalAmount;
        }
    }

}
