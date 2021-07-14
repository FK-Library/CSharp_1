using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public interface IBasketTotalCalculator
    {
        decimal GetTotalPrice(IBasketService basket);
    }
}
