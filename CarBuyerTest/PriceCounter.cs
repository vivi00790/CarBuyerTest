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
            

            var monthCount = 0;
            double currentStartPrice = startPrice;
            double currentTargetPrice = targetStartPrice;
            var currentSaving = 0;
            double currentDepreciation = decreasingRate/100;
            while (true)
            {
                if (currentStartPrice+currentSaving>=currentTargetPrice)
                {
                    return new[] {monthCount, Convert.ToInt32(currentStartPrice+currentSaving - currentTargetPrice)};
                }

                currentStartPrice *= (1 - currentDepreciation);
                currentTargetPrice *= (1 - currentDepreciation);
                currentSaving += savingPerMonth;
                if (monthCount != 0 && monthCount % 2 == 0)
                {
                    //currentDepreciation += 0.005;
                    currentDepreciation *= 1.005;
                }

                monthCount++;
            }
            return new[] {(targetStartPrice - startPrice)/savingPerMonth,targetStartPrice-startPrice};
        }
    }
}
