using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class PriceService
    {
        private IList<Tuple<string, decimal>> basicPrices = null;

        private IPriceStrategy priceStrategy;

        public PriceService(string pricePattern)
        {
            priceStrategy = GetPriceStrategy(pricePattern);

            basicPrices = GetBasePrices();
        }

        private IList<Tuple<string, decimal>> GetBasePrices()
        {
            var prices = new List<Tuple<string, decimal>>();
            prices.Add(new Tuple<string, decimal>("DC", 288));
            prices.Add(new Tuple<string, decimal>("CDC", 388));
            prices.Add(new Tuple<string, decimal>("BJ", 188));
            prices.Add(new Tuple<string, decimal>("SBC", 288));
            prices.Add(new Tuple<string, decimal>("SCF", 588));

            return prices;
        }

        private IPriceStrategy GetPriceStrategy(string pricePattern)
        {
            switch (pricePattern)
            {
                case "activityPattern":
                    return new ActivityPriceStrategy();

                case "discountPattern":
                    return new DiscountStrategy();
                default:
                    throw new NotImplementedException($"pattern hasn't been implement yet {pricePattern}");
            }
        }

        public decimal GetPrice(string roomType, DateTime bizDay)
        {
            var price = basicPrices.FirstOrDefault(b => b.Item1 == roomType);
            if(price == null)
            {
                throw new Exception($"haven't config roomtype:{roomType} basic price");
            }
            var result = priceStrategy.GetPrice(roomType, bizDay, price.Item2);

            return Math.Round(result, 2);
        }
    }
}
