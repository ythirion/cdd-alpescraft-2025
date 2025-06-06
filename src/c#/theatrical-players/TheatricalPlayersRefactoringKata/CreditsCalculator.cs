using System;

namespace TheatricalPlayersRefactoringKata
{
    internal static class CreditsCalculator
    {
        public static int NotCrappyTreatment(MyRepository performanceType, int audience)
            => Math.Max(audience - 30, 0) +
               (performanceType == MyRepository.Comedy ? (int) Math.Floor((decimal) audience / 5) : 0);
    }
}