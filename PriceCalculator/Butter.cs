using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public class Butter : IProduct
    {
        public string Product => "Butter";

        public decimal Price => 0.8m;
    }
}
