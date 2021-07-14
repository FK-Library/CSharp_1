using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public class BasketService : IBasketService
    {
        private List<IProduct> products;
        public BasketService(List<IProduct> products)
        {
            this.products = products;
        }
        public List<IProduct> Products => this.products;
        //{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(IProduct product)
        {
            this.products.Add(product);
            //throw new NotImplementedException();
        }
    }
}
