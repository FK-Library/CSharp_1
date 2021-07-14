using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public interface IApplyOfferService
    {
        bool CanApply(IBasketService basketService);
        IBasketService Apply(IBasketService basketService);
    }
}
