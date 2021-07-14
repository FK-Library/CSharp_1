using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriceCalculator
{
    public class ThreeMilkAnd4thMilkIsFree : IApplyOfferService
    {
        //
        private string description => "Buy 3 Milk and get the 4th milk for free";
        private decimal reduction;
        public ThreeMilkAnd4thMilkIsFree()
        {
            this.reduction = 0m;
        }

        public bool CanApply(IBasketService basketService)
        {
            int milkCount = 0;
            bool hasFourMilk = false;

            var numberOfMilkinBasket = basketService.Products.Select(x => x.Product.Equals("Milk")).Count();
            if (numberOfMilkinBasket/4 >= 1)
            {
                this.reduction = (numberOfMilkinBasket/4) * -1.15m;
                hasFourMilk = true;
            }
            return hasFourMilk;
        }

        public IBasketService Apply(IBasketService basketService)
        {
            basketService.Add(new Offer(this.description, this.reduction));
            return basketService;
        }
    }
}
