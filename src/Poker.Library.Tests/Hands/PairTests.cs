using Poker.Library.Hands;

namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class PairTests
{
    [Fact]
    public void Qualify_True_When_Pair_Exists()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.TwoOfHearts,
            deck.TwoOfDiamonds,
            deck.FourOfHearts,
            deck.EightOfHearts,
            deck.NineOfHearts
        };

        List<ICard> expectedHand = new() {
            deck.TwoOfHearts,
            deck.TwoOfDiamonds
        };

        List<ICard> expectedKicker = new() {
            deck.FourOfHearts,
            deck.EightOfHearts,
            deck.NineOfHearts
        };

        var sut = new Pair();

        // act
        var result = sut.Qualify(deck, playerCards);

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
            deck.ThreeOfDiamonds,
            deck.FourOfHearts,
            deck.EightOfHearts,
            deck.NineOfHearts
        };

        var sut = new Pair();

        // act
        var result = sut.Qualify(deck, playerCards);

        // assert
        result.Qualifies.Should().BeFalse();
    }
}
