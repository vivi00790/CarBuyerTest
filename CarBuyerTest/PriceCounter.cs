using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarBuyerTest
{
    class PriceCounter
    {
        public static int[] Count(int startPrice, int targetPrice, int savingPerMonth, double startDepreciation)
        {
            

            var monthCount = 0;
            double currentStartPrice = startPrice;
            double currentTargetPrice = targetPrice;
            var currentSaving = 0;
            var currentDepreciation = startDepreciation/100;

            bool CanBuy()
            {
                return currentStartPrice + currentSaving >= currentTargetPrice;
            }

            bool IsEvenMonth()
            {
                return  monthCount % 2 == 1;
            }

            
            while (true)
            {
                
                if (CanBuy())
                {
                    return new[] {monthCount, Convert.ToInt32(currentStartPrice+currentSaving - currentTargetPrice)};
                }

                if (IsEvenMonth())
                {
                    currentDepreciation += 0.005;
                }

                currentStartPrice *= (1 - currentDepreciation);

                currentTargetPrice *= (1 - currentDepreciation);
//                currentStartPrice -= startPriceOld * currentDepreciation;
//
//                currentTargetPrice -=  startPriceNew*currentDepreciation;
                currentSaving += savingPerMonth;
                monthCount++;

                if (CanBuy())
                {
                    return new[] { monthCount, Convert.ToInt32(currentStartPrice + currentSaving - currentTargetPrice) };
                }
            }
        }
    }
}
