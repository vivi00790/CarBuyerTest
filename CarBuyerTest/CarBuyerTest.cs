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
            AllElementsAreEqual(setExceptArray(0, 0), PriceCounter.Count(8000, 8000, 1000, 1.5));
        }

        [TestMethod]
        public void Start_price_larger_then_car_price_should_return_0_and_priceDiff()
        {
            AllElementsAreEqual(setExceptArray(0, 4000), PriceCounter.Count(12000, 8000, 1000, 1.5));
            AllElementsAreEqual(setExceptArray(0, 2000), PriceCounter.Count(10000, 8000, 1000, 1.5));
        }

        [TestMethod]
        public void Start_price_smaller_then_car_price_should_return_correct_result()
        {
            AllElementsAreEqual(setExceptArray(1,15), PriceCounter.Count(2000, 3000, 1000, 1.5));
            AllElementsAreEqual(setExceptArray(2,60), PriceCounter.Count(2000, 4000, 1000, 1.5));
//            AllElementsAreEqual(setExceptArray(6,766), PriceCounter.Count(2000, 8000, 1000, 1.5));
        }


        private void AllElementsAreEqual(int[] expect, int[] actual)
        {
            Assert.IsTrue(expect.Length == actual.Length);
            for (int i = 0; i < expect.Length; i++)
            {
                Assert.AreEqual(expect[i],actual[i]);
            }
        }

        private int[] setExceptArray(int expectMonth, int expectPrize)
        {
            return new[] {expectMonth, expectPrize};
        }

        
    }
}
