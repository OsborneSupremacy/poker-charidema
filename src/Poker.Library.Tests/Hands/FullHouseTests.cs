namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class FullHouseTests
{
    [Fact]
    public void Qualify_True_When_FullHouse_Exist()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.TwoOfHearts,
            deck.TwoOfDiamonds,
            deck.TwoOfSpades,
            deck.FourOfDiamonds,
            deck.FourOfHearts
        };

        var sut = new FullHouse();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(playerCards);
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_False_When_No_FullHouse_Exists()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.TwoOfHearts,
            deck.TwoOfDiamonds,
            deck.TwoOfSpades,
            deck.FourOfDiamonds,
            deck.FiveOfDiamonds
        };

        var sut = new FullHouse();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeFalse();
    }
}
