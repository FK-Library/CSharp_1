using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public class Bread : IProduct
    {
        public string Product => "Bread";
        public decimal Price => 1.0m;
    }
}
