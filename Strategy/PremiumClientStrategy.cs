using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class PremiumClientStrategy : IProductPaymentStrategy
    {
        public decimal ProductProcessPayment(decimal price)
        {
            return price * 0.8m;
        }
    }
}
