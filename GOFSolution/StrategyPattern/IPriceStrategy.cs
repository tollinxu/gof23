using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IPriceStrategy
    {
        decimal GetPrice(string roomType, DateTime bizDay, Decimal basePrice);
    }
}
