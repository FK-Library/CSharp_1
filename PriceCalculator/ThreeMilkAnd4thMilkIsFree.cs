using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriceCalculator
{
    public class ThreeMilkAnd4thMilkIsFree : IApplyOfferService
    {
        private string description => "Buy 3 Milk and get the 4th milk for free";
        private decimal reduction;
        public ThreeMilkAnd4thMilkIsFree()
        {
            this.reduction = 0m;
        }
                
        public bool CanApply(IBasketService basketService)
        {
            bool hasFourMilk = false;
            var numberOfMilkinBasket = 0;
            var milkCost = 0m;

            foreach (var product in basketService.Products())
            {
                if (product.Product().Equals("Milk"))
                {
                    numberOfMilkinBasket ++;
                    milkCost = product.Price();
                }
            }

            if (numberOfMilkinBasket >= 4)
            {
                this.reduction = (numberOfMilkinBasket % 4) * milkCost;
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
