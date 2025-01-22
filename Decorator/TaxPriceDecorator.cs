using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class TaxPriceDecorator : IPriceCalculator
    {
        private readonly IPriceCalculator _priceCalculator;
        private readonly decimal _tax;

        public TaxPriceDecorator(IPriceCalculator priceCalculator, decimal tax)
        {
            _priceCalculator = priceCalculator;
            _tax = tax;
        }
        public decimal Calculate(decimal price)
        {
            var priceWithTax = price *= (1+ _tax);
            var priceCalculator = _priceCalculator.Calculate(priceWithTax);
            return priceCalculator;
        }

        public string GetDescription()
        {
            return _priceCalculator.GetDescription() + $" Tax {_tax}";
        }
    }
}
