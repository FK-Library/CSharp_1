using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public class TwoButterFiftyPercentOffBreadOffer : IApplyOfferService
    {
        private string  description => "Buy 2 butter get 50% off bread.";
        private decimal reduction;
        public TwoButterFiftyPercentOffBreadOffer()
        {
            this.reduction = 0m;
        }
       
        public bool CanApply(IBasketService basketService)
        {
            int butterCount = 0;
            bool hasBread = false;

            foreach (var product in basketService.Products)
            {
                if (product.Product.Equals("Butter"))
                {
                    butterCount++;
                }
                else if (product.Product.Equals("Bread"))
                {
                    hasBread = true;
                    this.reduction = product.Price * -0.5m;
                }
            }

            return (butterCount >= 2) && hasBread;
        }

        public IBasketService Apply(IBasketService basketService)
        {
            basketService.Add(new Offer(this.description, this.reduction));
            return basketService;
        }
    }
}
