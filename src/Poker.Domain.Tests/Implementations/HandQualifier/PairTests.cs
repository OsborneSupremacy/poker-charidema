namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class PairTests
{
    [Fact]
    public void Qualify_True_When_Pair_Exists()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.TwoOfHearts,
            Cards.TwoOfDiamonds,
            Cards.FourOfHearts,
            Cards.EightOfHearts,
            Cards.NineOfHearts
        };

        List<Card> expectedHand = new() {
            Cards.TwoOfHearts,
            Cards.TwoOfDiamonds
        };

        List<Card> expectedKicker = new() {
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
        result.HandQualification.Should().Be(HandQualifications.Qualifies);
        result.HandCards.Should().BeEquivalentTo(expectedHand);
        result.Kickers.Should().BeEquivalentTo(expectedKicker);
        result.DeadCards.Should().BeEmpty();
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
