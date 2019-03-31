using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarBuyerTest
{
    [TestClass]
    public class CarBuyerTest
    {
        [TestMethod]
        public void Start_and_target_price_are_equal_should_return_0_0()
        {
            AllElementsAreEqual(setExceptArray(0, 0), PriceCounter.Count(8000, 8000, 1000, 1.5));
        }

        [TestMethod]
        public void Start_larger_then_target_price_should_return_0_priceDiff()
        {
            AllElementsAreEqual(setExceptArray(0, 4000), PriceCounter.Count(12000, 8000, 1000, 1.5));
            AllElementsAreEqual(setExceptArray(0, 2000), PriceCounter.Count(10000, 8000, 1000, 1.5));
        }

        [TestMethod]
        public void Validate_saving()
        {
            AllElementsAreEqual(setExceptArray(1, 0),PriceCounter.Count(1000,2000,1000,0));
            AllElementsAreEqual(setExceptArray(20, 0),PriceCounter.Count(1000,2000,50,0));
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
