using Poker.Library.Hands;

namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class FlushTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Flush()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.AceOfHearts,
            deck.TenOfHearts,
            deck.FiveOfHearts,
            deck.ThreeOfHearts,
            deck.TwoOfHearts
        };

        var sut = new Flush();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(playerCards);
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Flushd()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.AceOfHearts,
            deck.TenOfHearts,
            deck.FiveOfHearts,
            deck.ThreeOfHearts,
            deck.TwoOfDiamonds
        };

        var sut = new FourOfAKind();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeFalse();
        result.HandCards.Should().BeEmpty();
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }
}
