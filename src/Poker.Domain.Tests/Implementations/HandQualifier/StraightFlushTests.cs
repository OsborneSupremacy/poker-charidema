namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class StraightFlushTests
{
    [Fact]
    public void Qualify_True_When_StraightFlush_Exists()
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
            Hand = Hands.StraightFlush
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
    public void Qualify_False_When_Straight_But_No_Flush_Exists()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.KingOfSpades,
            Cards.QueenOfSpades,
            Cards.JackOfSpades,
            Cards.TenOfSpades,
            Cards.NineOfClubs
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.StraightFlush
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
    }

    [Fact]
    public void Qualify_False_When_Flush_But_No_Straight_Exists()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.KingOfSpades,
            Cards.QueenOfSpades,
            Cards.JackOfSpades,
            Cards.TenOfSpades,
            Cards.EightOfSpades
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.StraightFlush
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
    }
}
