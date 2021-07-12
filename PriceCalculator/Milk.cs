using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public class Milk : IProduct
    {
        public string Product => "Milk";

        public decimal Price => 1.15m;
    }
}
