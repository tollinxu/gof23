using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    class RateDiscount : DiscountBase
    {
        public override decimal CacaulatePrice(decimal basePrice, decimal discount)
        {
            return basePrice * discount;
        }
    }
}
