using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarBuyerTest
{
    [TestClass]
    public class CarBuyerTest
    {
        [TestMethod]
        public void Equal_start_price_and_car_price_should_return_0_0()
        {
            Assert.IsTrue(AllElementsAreEqual(setExceptArray(0, 0), PriceCounter.Count(8000, 8000, 1000, 1.5)));
        }


        private bool AllElementsAreEqual(int[] expect, int[] actual)
        {
            return expect.Where((_, i) => _ == actual[i]).Count() == actual.Length;
        }

        private int[] setExceptArray(int expectMonth, int expectPrize)
        {
            return new[] {expectMonth, expectPrize};
        }

        
    }
}
