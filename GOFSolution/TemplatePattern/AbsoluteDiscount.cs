using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    class AbsoluteDiscount : DiscountBase
    {
        public override decimal CacaulatePrice(decimal basePrice, decimal discount)
        {
            return discount;
        }
    }
}
