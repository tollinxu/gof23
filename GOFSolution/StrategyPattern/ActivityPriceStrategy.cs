using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class ActivityPriceStrategy : IPriceStrategy
    {
        private IList<Tuple<string, decimal>> activities = null;
        public ActivityPriceStrategy()
        {
            activities = new List<Tuple<string, decimal>>();
            activities.Add(new Tuple<string, decimal>("DC", 256));
            activities.Add(new Tuple<string, decimal>("CDC", 356));
            activities.Add(new Tuple<string, decimal>("BJ", 156));
            activities.Add(new Tuple<string, decimal>("SBC", 256));
        }
        public decimal GetPrice(string roomType, DateTime bizDay, Decimal basePrice)
        {
            var activity = activities.FirstOrDefault(a => a.Item1 == roomType);
            if(activity == null)
            {
                return basePrice;
            }
            return activity.Item2;
        }
    }
}
