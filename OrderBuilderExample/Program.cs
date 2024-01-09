
using OrderBuilderExample;

Product product1 = new Product("Product 1", 50.0m);
Product product2 = new Product("Product 2", 30.0m);

ShoppingCart shoppingCart = new ShoppingCart();

shoppingCart
    .AddProduct(product1)
    .AddProduct(product2);


DiscountCalculator discountCalculator = totalAmount => totalAmount * 0.2m; // 
Order.OrderBuilder orderBuilder = shoppingCart.Checkout(discountCalculator);


Order finalOrder = orderBuilder.Build();


Console.WriteLine("\nFinal Order Details:");
foreach (var product in finalOrder.Products)
{
    Console.WriteLine($"Product: {product.Name}, Price: {product.Price:C}");
}

Console.WriteLine($"Total Amount: {finalOrder.TotalAmount:C}");
    
