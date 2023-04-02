using Poker.Library.Hands;

namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class HighCardTests
{
    [Fact]
    public void Qualify_Get_Highest_Ranking_Card()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.AceOfSpades,
            deck.KingOfSpades,
            deck.QueenOfSpades,
            deck.JackOfSpades,
            deck.TenOfSpades
        };

        List<ICard> expectedHand = new() {
            deck.AceOfSpades
        };

        List<ICard> expectedKicker = new() {
            deck.KingOfSpades,
            deck.QueenOfSpades,
            deck.JackOfSpades,
            deck.TenOfSpades
        };

        var sut = new HighCard();

        // act
        var result = sut.Qualify(deck, playerCards);

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(expectedHand);
        result.Kickers.Should().BeEquivalentTo(expectedKicker);
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_Get_Joker_When_Joker_Is_Highest()
    {
        // arrange
        Classic.Deck deck = new(1);

        List<ICard> playerCards = new() {
            deck.Jokers.First(),
            deck.KingOfSpades,
            deck.QueenOfSpades,
            deck.JackOfSpades,
            deck.TenOfSpades
        };

        List<ICard> expectedHand = new() {
            deck.Jokers.First()
        };

        List<ICard> expectedKicker = new() {
            deck.KingOfSpades,
            deck.QueenOfSpades,
            deck.JackOfSpades,
            deck.TenOfSpades
        };

        var sut = new HighCard();

        // act
        var result = sut.Qualify(deck, playerCards);

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(expectedHand);
        result.Kickers.Should().BeEquivalentTo(expectedKicker);
        result.DeadCards.Should().BeEmpty();
    }
}
