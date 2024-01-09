using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuilderPatternExample
{
    public class Product
    {
        private string _name;
        private double _price;
        private string _description;

        private Product(string name, double price, string description)
        {
            _name = name;
            _price = price;
            _description = description;
        }

        public void Show()
        {
            Console.WriteLine($" Product Name: {_name}\n Product Price: {_price}\n Product Description: {_description}");
        }

        public class ProductBuilder
        {
            private string productName;
            private double productPrice;
            private string productDescription;

            public ProductBuilder WithName(string name)
            {
                productName = name;
                return this;
            }
            public ProductBuilder WithPrice(double price)
            {
                productPrice = price;
                return this;
            }

            public ProductBuilder WithDescription(string description)
            {
                productDescription = description;
                return this;
            }

            public Product Build()
            {
                return new Product(productName, productPrice, productDescription);
            }

        }
    }
}
