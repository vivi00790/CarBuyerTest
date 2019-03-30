using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarBuyerTest
{
    [TestClass]
    public class CarBuyerTest
    {
        [TestMethod]
        public void equal_start_prize_and_car_prize_should_return_0_0()
        {

            Assert.AreEqual(setExceptArray(0, 0), PriceCounter.Count(8000, 8000, 1000, 1.5));
        }

        private int[] setExceptArray(int expectMonth, int expectPrize)
        {
            return new[] {expectMonth, expectPrize};
        }
    }
}
