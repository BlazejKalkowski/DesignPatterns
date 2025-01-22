using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal interface IPriceCalculator
    {
        string GetDescription();
        decimal Calculate(decimal price);
    }
}
