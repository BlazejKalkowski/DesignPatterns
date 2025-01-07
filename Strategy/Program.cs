using Strategy;

List<Product> products = new() 
{
    new Product { Name = "Melon", ProductType = ProductType.Standard, Price = 200m },
    new Product { Name = "Apples", ProductType = ProductType.Premium, Price = 300m },
    new Product { Name = "Mango", ProductType = ProductType.Standard, Price = 400m },
    new Product { Name = "Lemon", ProductType = ProductType.Premium, Price = 500m },
};

decimal orderSum = products.Sum(x => x.Price);
Console.WriteLine($"Sum of the order before the reductions is {orderSum}");
orderSum = 0m;

foreach (var item in products)
{
    var strategy = GetStrategy(item.ProductType);
    orderSum += strategy.ProductProcessPayment(item.Price);
}

Console.WriteLine($"Sum of the order after reductions is {orderSum}");
Console.ReadKey();

static IProductPaymentStrategy GetStrategy(ProductType productType)
{
    return productType switch
    {
        ProductType.Premium => new PremiumClientStrategy(),
        _ => new StandardClientStrategy()
    };
}