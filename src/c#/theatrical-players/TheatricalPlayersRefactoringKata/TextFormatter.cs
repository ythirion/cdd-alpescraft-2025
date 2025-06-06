using System;
using System.Globalization;

namespace TheatricalPlayersRefactoringKata
{
    internal static class TextFormatter
    {
        private static readonly CultureInfo FormatProvider = new("en-US");

        internal static string DoNotTouch(string name, int amount, int audience)
            => string.Format(FormatProvider, "  {0}: {1:C} ({2} seats)\n", name, amount / 100, audience);

        internal static string BeCareful(
            string customer,
            Ss ss) =>
            string.Format(FormatProvider,
                "Statement for {0}\n{1}Amount owed is {2:C}\nYou earned {3} credits\n",
                customer, ss.Text, Convert.ToDecimal(ss.Amount / 100), ss.Credits);
    }
}