namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class HighCardTests
{
    [Fact]
    public void Qualify_Get_Highest_Ranking_Card()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.AceOfSpades,
            Cards.KingOfSpades,
            Cards.QueenOfSpades,
            Cards.JackOfSpades,
            Cards.TenOfSpades
        };

        List<Card> expectedHand = new() {
            Cards.AceOfSpades
        };

        List<Card> expectedKicker = new() {
            Cards.KingOfSpades,
            Cards.QueenOfSpades,
            Cards.JackOfSpades,
            Cards.TenOfSpades
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.HighCard
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
    public void Qualify_Get_Joker_When_Joker_Is_Highest()
    {
        // arrange
        var joker = Cards.CreateJoker();

        List<Card> playerCards = new() {
            joker,
            Cards.KingOfSpades,
            Cards.QueenOfSpades,
            Cards.JackOfSpades,
            Cards.TenOfSpades
        };

        List<Card> expectedHand = new() {
            joker
        };

        List<Card> expectedKicker = new() {
            Cards.KingOfSpades,
            Cards.QueenOfSpades,
            Cards.JackOfSpades,
            Cards.TenOfSpades
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.HighCard
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Qualifies);
        result.HandCards.Should().BeEquivalentTo(expectedHand);
        result.Kickers.Should().BeEquivalentTo(expectedKicker);
        result.DeadCards.Should().BeEmpty();
    }
}
