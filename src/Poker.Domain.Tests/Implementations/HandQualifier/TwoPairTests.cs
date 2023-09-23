namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class TwoPairTests
{
    [Fact]
    public void Qualify_True_When_Two_Pairs_Exist()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.TwoOfHearts,
            Cards.TwoOfDiamonds,
            Cards.FourOfHearts,
            Cards.FourOfDiamonds,
            Cards.NineOfHearts
        };

        List<Card> expectedHand = new() {
            Cards.TwoOfHearts,
            Cards.TwoOfDiamonds,
            Cards.FourOfHearts,
            Cards.FourOfDiamonds,
        };

        List<Card> expectedKicker = new() {
            Cards.NineOfHearts
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.TwoPair
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
            Cards.TwoOfDiamonds,
            Cards.FourOfHearts,
            Cards.FiveOfHearts,
            Cards.NineOfHearts
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.TwoPair
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
    }
}
