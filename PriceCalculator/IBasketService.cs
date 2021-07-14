using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public interface IBasketService
    {
        void Add(IProduct product);
        List<IProduct> Products(); // { get;  }
    }
}
