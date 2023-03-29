using Poker.Library.Hands;

namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class ThreeOfAKindTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Three_Of_A_Kind()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.AceOfHearts,
            deck.AceOfDiamonds,
            deck.AceOfClubs,
            deck.FourOfHearts,
            deck.NineOfHearts
        };

       var sut = new ThreeOfAKind();

        // act
        var result = sut.Qualify(deck, playerCards);

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(new List<ICard>()
        {
            deck.AceOfHearts,
            deck.AceOfDiamonds,
            deck.AceOfClubs
        });
        result.Kickers.Should().BeEquivalentTo(new List<ICard>() { deck.NineOfHearts, deck.FourOfHearts });
        result.DeadCards.Any().Should().BeFalse();
    }

    [Fact]
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Three_Of_A_Kind()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.AceOfHearts,
            deck.TwoOfDiamonds,
            deck.ThreeOfClubs,
            deck.FourOfHearts,
            deck.FiveOfHearts
        };

        var sut = new ThreeOfAKind();

        // act
        var result = sut.Qualify(deck, playerCards);

        // assert
        result.Qualifies.Should().BeFalse();
        result.HandCards.Should().BeEmpty();
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }
}

