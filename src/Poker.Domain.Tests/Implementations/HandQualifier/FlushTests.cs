namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FlushTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Flush()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.AceOfHearts,
            Cards.TenOfHearts,
            Cards.FiveOfHearts,
            Cards.ThreeOfHearts,
            Cards.TwoOfHearts
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.Flush
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Qualifies);
        result.HandCards.Should().BeEquivalentTo(playerCards);
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Flushd()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.AceOfHearts,
            Cards.TenOfHearts,
            Cards.FiveOfHearts,
            Cards.ThreeOfHearts,
            Cards.TwoOfDiamonds
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.FullHouse
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
        result.HandCards.Should().BeEmpty();
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }
}
