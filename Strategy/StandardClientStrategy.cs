using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class StandardClientStrategy : IProductPaymentStrategy
    {
        public decimal ProductProcessPayment(decimal price)
        {
            return price;
        }
    }
}
