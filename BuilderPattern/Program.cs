using BuilderPatternExample;

var product1 = new Product
.ProductBuilder()
    .WithName("Samsung S90C")
    .WithPrice(1100)
    .WithDescription("Screen Size 65,Resolution 3,840 x 2,160,Refresh Rate 120Hz (Up to 144Hz),Set Size with Stand (WxHxD) 1444.3 x 896.6 x 265.9 mm.")
    .Build();
product1.Show();
Console.WriteLine(new String('-', 25));
var product2 = new Product
.ProductBuilder()
    .WithName("iPhone 15 Pro Max")
    .WithPrice(1170)
    .WithDescription("Do not include a power adapter or EarPods. Included in the box is a USB‑C Charge Cable that supports fast charging. Bigger screen, bigger battery.")
    .Build();
product2.Show();










