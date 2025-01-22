namespace Decorator
{
    internal class BasePriceCalculator : IPriceCalculator
    {
        public string GetDescription()
        {
            var price = "Base price";
            return price;
        }
        public decimal Calculate(decimal price)
        {
            return price;
        }
    }
}
