using Decorator;
using System;

IPriceCalculator priceCalculator = new BasePriceCalculator();
Console.WriteLine($"Description: {priceCalculator.GetDescription()}");
Console.WriteLine($"Description: {priceCalculator.Calculate(200)}");


priceCalculator = new TaxPriceDecorator(priceCalculator,0.23m);
Console.WriteLine($"Description: {priceCalculator.GetDescription()}");
Console.WriteLine($"Description: {priceCalculator.Calculate(200)}");
Console.ReadKey();







