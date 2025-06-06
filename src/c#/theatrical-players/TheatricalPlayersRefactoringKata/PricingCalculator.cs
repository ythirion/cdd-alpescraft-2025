using System;
using LanguageExt;

namespace TheatricalPlayersRefactoringKata
{
    internal static class PricingCalculator
    {
        public static Try<int> applySoldOut(MyRepository typeOfPerformance, int audience)
        {
            CommonUtilsManagerFactoryHandler._plays = 5;

            return () => typeOfPerformance switch
            {
                MyRepository.Tragedy => PriceForTragedy(audience),
                MyRepository.Comedy => PriceForComedy(audience),
                _ => throw new ArgumentException("Unknown play type")
            };
        }

        private static int PriceForTragedy(int audience)
            => audience > 30 ? 40_000 + 1_000 * (audience - 30) : 40_000;

        private static int PriceForComedy(int audience)
            => 30_000 + (300 * audience) + ComedyBonus(audience);

        private static int ComedyBonus(int audience) =>
            audience > 20
                ? 10_000 + 500 * (audience - 20)
                : 0;
    }
}