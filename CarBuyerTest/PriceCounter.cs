using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyerTest
{
    class PriceCounter
    {
        public static int[] Count(int startPrice, int targetStartPrice, int savingPerMonth, double decreasingRate)
        {
            if (startPrice>=targetStartPrice)
            {
                return new[] {0, startPrice - targetStartPrice};
            }
            return new[] {(targetStartPrice - startPrice)/savingPerMonth,targetStartPrice-startPrice};
        }
    }
}
