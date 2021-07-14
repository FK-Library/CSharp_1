using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public class BasketService : IBasketService
    {
        public List<IProduct> basket;

        public BasketService() 
        {
            this.basket = new List<IProduct>(); 
        }

        public List<IProduct> Products() => this.basket;

        public void Add(IProduct product)
        {
            this.basket.Add(product);
        }

       
    }
}
