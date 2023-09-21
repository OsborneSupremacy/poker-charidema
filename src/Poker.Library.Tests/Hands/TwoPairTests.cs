namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class TwoPairTests
{
    [Fact]
    public void Qualify_True_When_Two_Pairs_Exist()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.TwoOfHearts,
            deck.TwoOfDiamonds,
            deck.FourOfHearts,
            deck.FourOfDiamonds,
            deck.NineOfHearts
        };

        List<ICard> expectedHand = new() {
            deck.TwoOfHearts,
            deck.TwoOfDiamonds,
            deck.FourOfHearts,
            deck.FourOfDiamonds,
        };

        List<ICard> expectedKicker = new() {
            deck.NineOfHearts
        };

        var sut = new TwoPair();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(expectedHand);
        result.Kickers.Should().BeEquivalentTo(expectedKicker);
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_False_When_No_Pair_Exists()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.TwoOfHearts,
            deck.TwoOfDiamonds,
            deck.FourOfHearts,
            deck.FiveOfHearts,
            deck.NineOfHearts
        };

        var sut = new TwoPair();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeFalse();
    }
}
