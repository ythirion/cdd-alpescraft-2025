using System;

namespace TheatricalPlayersRefactoringKata
{
    internal record Ss(string Text, int Amount, int Credits);

    internal static class Extensions
    {
        public static string FormatFor(
            this Ss ss,
            string customer,
            Func<string, Ss, string> formatter)
            => formatter(customer, ss);

        internal static Ss Append(
            this Ss ss,
            Ss append) 
            => new(Text: ss.Text + append.Text, Amount: ss.Amount + append.Amount, Credits: ss.Credits + append.Credits);
    }
}