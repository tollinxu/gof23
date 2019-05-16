using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class DiscountBase
    {
        public abstract decimal CacaulatePrice(decimal basePrice, decimal discount);

        public decimal GetPrice(decimal basePrice, decimal discount)
        {
            var discountOffValue = CacaulatePrice(basePrice, discount);

            return basePrice - discountOffValue;
        }
    }
}
