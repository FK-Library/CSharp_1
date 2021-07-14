using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriceCalculator
{
    public class TotalBasketCalculation : IBasketTotalCalculator
    {
        private List<IApplyOfferService> offers;

        public TotalBasketCalculation(List<IApplyOfferService> offers)
        {
            this.offers = offers;
        }

        private IBasketService ApplyOffers(IBasketService basket)
        {
            foreach (var offer in this.offers)
            {
                if (offer.CanApply(basket))
                {
                    basket = offer.Apply(basket);
                }
            }
            return basket;
        }

        public decimal GetTotalPrice(IBasketService basket)
        {
            var offerBasket = this.ApplyOffers(basket);
            decimal totalCost = 0;

            foreach (var product in basket.Products())
            {
                totalCost += product.Price();
            }
            return totalCost;
        }
    }
}
