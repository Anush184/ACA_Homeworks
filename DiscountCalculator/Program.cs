using ShoppingCardDiscountCalculator;

ShoppingCart cart = new ShoppingCart { TotalAmount = 1500.0 };


DiscountCalculator regularCustomerDiscount = Discounts.RegularCustomerDiscount;
DiscountCalculator vipCustomerDiscount = Discounts.VIPCustomerDiscount;
DiscountCalculator saleDiscount = Discounts.SaleDiscount;


Console.WriteLine($"Total amount before discount: ${cart.TotalAmount}");

double discountedRegulyarAmount = regularCustomerDiscount(cart.TotalAmount);
Console.WriteLine($"Regular Customer Discount: ${discountedRegulyarAmount}");

double discountedVIPAmount= vipCustomerDiscount(cart.TotalAmount);
Console.WriteLine($"VIP Customer Discount: ${discountedVIPAmount}");

double discountedSaleAmount = saleDiscount(cart.TotalAmount);
Console.WriteLine($"Sale Discount: ${discountedSaleAmount}");










