using Poker.Library.Hands;
using System.Diagnostics.CodeAnalysis;

namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class PairTests
{
    [Fact]
    public async Task Qualify_True_When_Pair_Exists()
    {
        // arrange
        var deck = new Classic.Deck();

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
        result.DeadCards.Any().Should().BeFalse();
    }
}
