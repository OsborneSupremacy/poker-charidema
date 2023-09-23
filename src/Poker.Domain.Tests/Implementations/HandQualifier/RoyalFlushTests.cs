namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]

public class RoyalFlushTests
{
    [Fact]
    public void Qualify_True_When_RoyalFlus_Exists()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.AceOfSpades,
            Cards.KingOfSpades,
            Cards.QueenOfSpades,
            Cards.JackOfSpades,
            Cards.TenOfSpades
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.RoyalFlush
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
    public void Qualify_False_When_StraightFlush_But_No_RoyalFlush_Exists()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.KingOfSpades,
            Cards.QueenOfSpades,
            Cards.JackOfSpades,
            Cards.TenOfSpades,
            Cards.NineOfSpades
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.RoyalFlush
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
    }
}
