using Poker.Domain.Tests.Extensions;

namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class PairTests
{
    [Fact]
    public void Qualify_True_When_Pair_Exists()
    {
        // arrange
        var builder = new HandBuilder()
            .ExpectedInHand(x =>
            {
                x.With(Cards.TwoOfHearts);
                x.With(Cards.TwoOfDiamonds);
            })
            .ExpectedInKicker(x =>
            {
                x.With(Cards.FourOfHearts);
                x.With(Cards.EightOfHearts);
                x.With(Cards.NineOfHearts);
            });

        var request = new QualifiedHandRequest
        {
            Cards = builder.GetPlayerCards(),
            RemainingCardCount = 0,
            Hand = Hands.Pair
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Qualifies);
        result.ShouldBeAsExpected(builder);
    }

    [Fact]
    public void Qualify_False_When_No_Pair_Exists()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.TwoOfHearts,
            Cards.ThreeOfDiamonds,
            Cards.FourOfHearts,
            Cards.EightOfHearts,
            Cards.NineOfHearts
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.Pair
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
    }
}
