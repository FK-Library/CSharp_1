using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PriceCalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SUT_Given1BreadAnd1Milk_ReturnsTotalOfTwoPointNintyFive()
        {
        }

        [TestMethod]
        public void SUT_Given2ButterAnd2Bread_ReturnsTotalOfThreePointTen()
        {
        }

        [TestMethod]
        public void SUT_Given4Milk_ReturnsTotalOfThreePointfourtyFive()
        {
        }

        [TestMethod]
        public void SUT_Given2ButterAnd1BreadAnd8Milk_ReturnsTotalOfNine()
        {
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
