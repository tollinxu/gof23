using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class DiscountStrategy : IPriceStrategy
    {
        private IList<Tuple<string, decimal>> discounts = null;
        public DiscountStrategy()
        {
            discounts = new List<Tuple<string, decimal>>();
            discounts.Add(new Tuple<string, decimal>("DC", 0.95m));
            discounts.Add(new Tuple<string, decimal>("CDC", 0.90m));
            discounts.Add(new Tuple<string, decimal>("BJ", 0.85m));
            discounts.Add(new Tuple<string, decimal>("SBC", 0.80m));
        }
        public decimal GetPrice(string roomType, DateTime bizDay, Decimal basePrice)
        {
            var distcount = discounts.FirstOrDefault(d => d.Item1 == roomType);
            if(distcount == null)
            {
                return basePrice;
            }
            return basePrice * distcount.Item2;
        }
    }
}
