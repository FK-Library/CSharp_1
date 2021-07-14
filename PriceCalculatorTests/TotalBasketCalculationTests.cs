using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceCalculator;
using System.Collections.Generic;

namespace PriceCalculatorTests
{
    [TestClass]
    public class TotalBasketCalculationTests
    {
        private  List<IApplyOfferService> offersCollection = 
            new List<IApplyOfferService>
            {
                new TwoButterFiftyPercentOffBreadOffer(),
                new ThreeMilkAnd4thMilkIsFree()
            };

        [TestMethod]
        public void GetTotalPrice_Given1BreadAnd1ButterAnd1Milk_ReturnsTotalOfTwoPointNintyFive()
        {
            // Arrange 
            var expected = 2.95m;
            var basketTotalCalculator = new TotalBasketCalculation(this.offersCollection);
            
            var basket = new BasketService();
            basket.Add(new Bread());
            basket.Add(new Milk());
            basket.Add(new Butter());

            // Act
            var result = basketTotalCalculator.GetTotalPrice(basket);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetTotalPrice_Given2ButterAnd2Bread_ReturnsTotalOfThreePointTen()
        {
            // Arrange 
            //(2*0.8) +(1*1.00) =2.60 -0.5 = 2.10 +1.00 = 3.10
            var expected = 3.10m;
            var basketTotalCalculator = new TotalBasketCalculation(this.offersCollection);

            var basket = new BasketService();
            basket.Add(new Bread());
            basket.Add(new Bread());
            basket.Add(new Butter());
            basket.Add(new Butter());

            // Act
            var result = basketTotalCalculator.GetTotalPrice(basket);

            // Assert
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void GetTotalPrice_Given4Milk_ReturnsTotalOfThreePointfourtyFive()
        {
            // Arrange 
            var expected = 3.45m;
            var basketTotalCalculator = new TotalBasketCalculation(this.offersCollection);

            var basket = new BasketService();
            basket.Add(new Milk());
            basket.Add(new Milk());
            basket.Add(new Milk());
            basket.Add(new Milk());

            // Act
            var result = basketTotalCalculator.GetTotalPrice(basket);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void GetTotalPrice_Given2ButterAnd1BreadAnd8Milk_ReturnsTotalOfNine()
        {
            // Arrange 
            //2*0.8 = 1.60 +1*1.00 = 2.60 /2 = 1.30 ->with 50 percent off
            //6*1.15 = 6.90
            //total should be 7.90
            var expected = 9m;
            var basketTotalCalculator = new TotalBasketCalculation(this.offersCollection);

            var basket = new BasketService();
            basket.Add(new Bread());
            basket.Add(new Milk());
            basket.Add(new Milk());
            basket.Add(new Milk());
            basket.Add(new Milk());
            basket.Add(new Milk());
            basket.Add(new Milk());
            basket.Add(new Milk());
            basket.Add(new Milk());
            basket.Add(new Milk());
            basket.Add(new Butter());
            basket.Add(new Butter());

            // Act
            var result = basketTotalCalculator.GetTotalPrice(basket);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

/*
 * • Given the basket has 1 bread, 1 butter and 1 milk when I total the basket then the total should be
£2.95
• Given the basket has 2 butter and 2 bread when I total the basket then the total should be £3.10
• Given the basket has 4 milk when I total the basket then the total should be £3.45
• Given the basket has 2 butter, 1 bread and 8 milk when I total the basket then the total should be
£9.00 
 * 
 */
