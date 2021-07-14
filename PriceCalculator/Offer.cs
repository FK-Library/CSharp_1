using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public class Offer : IProduct
    {
        private string description;
        private decimal reduction;

        public Offer(string description, decimal reduction)
        {
            this.description = description;
            this.reduction = reduction;
        }

        public string Product() => this.description;

        public decimal Price() => this.reduction;
    }
}
