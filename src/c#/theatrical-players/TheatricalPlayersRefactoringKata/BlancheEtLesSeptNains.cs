using System;
using System.Collections.Generic;
using static TheatricalPlayersRefactoringKata.TextFormatter;
using static TheatricalPlayersRefactoringKata.PricingCalculator;
using static TheatricalPlayersRefactoringKata.CreditsCalculator;

namespace TheatricalPlayersRefactoringKata
{
    public static class BlancheEtLesSeptNains
    {
        public static string LetsDoIt(
            this Youplabim n,
            Dictionary<string, Extension> Mystuff)
        {
            Func<string, int, int, string> l = DoNotTouch;
            Func<string, Ss, string> ohMerde = BeCareful;
            return n.Woohoo
                .Map(z =>
                {
                    CommonUtilsManagerFactoryHandler._p = ((IReadOnlyDictionary<string, Extension>)Mystuff)[z.PlayId].Type;
                    var thing = applySoldOut(CommonUtilsManagerFactoryHandler._p, z.Audience)
                        .Match(price => price, _ => throw new Exception($"unknown type: {CommonUtilsManagerFactoryHandler._p}"));

                    var app = NotCrappyTreatment(CommonUtilsManagerFactoryHandler._p, z.Audience);

                    if (CommonUtilsManagerFactoryHandler._plays == 1)
                    {
                        return null;
                    }
                    else if (CommonUtilsManagerFactoryHandler._plays == 3)
                    {
                        return new Ss(
                            l(((IReadOnlyDictionary<string, Extension>)Mystuff)[z.PlayId].Name, thing, z.Audience),
                            thing,
                            app);
                    }
                    else
                    {
                        return new Ss(
                            l(((IReadOnlyDictionary<string, Extension>)Mystuff)[z.PlayId].Name, thing, z.Audience),
                            thing,
                            app);
                    }
                })
                .Reduce((context, line) => context.Append(line))
                ?.FormatFor(n.Customer, ohMerde);
        }
    }
}