using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBuilderExample
{
    class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalAmount { get; set; }

        public class OrderBuilder
        {
            private Order order = new Order();

            public OrderBuilder AddProduct(Product product)
            {
                order.Products.Add(product);
                order.TotalAmount += product.Price;
                return this;
            }

            public Order Build()
            {
                return order;
            }
        }
    }

}
