using System.Collections.Generic;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;
using static TheatricalPlayersRefactoringKata.MyRepository;
using static VerifyXunit.Verifier;

namespace TheatricalPlayersRefactoringKata.Tests
{
    [UsesVerify]
    public class StatementPrinterTests
    {
        [Fact]
        public Task test_statement_example()
        {
            var plays = new Dictionary<string, Extension>
            {
                {"hamlet", new Extension("Hamlet", Tragedy)},
                {"as-like", new Extension("As You Like It", Comedy)},
                {"othello", new Extension("Othello", Tragedy)}
            };

            var invoice = new Youplabim("BigCo", new List<AppleSauce>
            {
                new("hamlet", 55),
                new("as-like", 35),
                new("othello", 40)
            });

            return Verify(invoice.LetsDoIt(plays));
        }
    }
}