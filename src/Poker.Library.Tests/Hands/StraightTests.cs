namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class StraightTests
{
    [Fact]
    public void Qualify_True_When_Straight_Exists()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.KingOfSpades,
            deck.QueenOfHearts,
            deck.JackOfClubs,
            deck.TenOfDiamonds,
            deck.NineOfSpades
        };

        var sut = new Straight();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(playerCards);
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_False_When_No_Straight_Exists()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.KingOfSpades,
            deck.QueenOfHearts,
            deck.JackOfClubs,
            deck.TenOfDiamonds,
            deck.EightOfSpades
        };

        var sut = new Straight();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeFalse();
    }

}
