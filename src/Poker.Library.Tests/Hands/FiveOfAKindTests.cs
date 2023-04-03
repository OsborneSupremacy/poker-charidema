using Poker.Library.Hands;

namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class FiveOfAKindTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Five_Of_A_Kind()
    {
        // arrange
        Classic.Deck deck = new(2);

        List<ICard> playerCards = new() {
            deck.AceOfHearts,
            deck.AceOfDiamonds,
            deck.AceOfClubs,
            deck.AceOfSpades,
            deck.Jokers.First()
        };

        var sut = new FiveOfAKind();

        // act
        var result = sut.Qualify
        (
            new HandRankingArgs { Deck = deck, PlayerCards = playerCards }
        );

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(playerCards);
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Any().Should().BeFalse();
    }

    [Fact]
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Five_Of_A_Kind()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.AceOfHearts,
            deck.AceOfDiamonds,
            deck.AceOfClubs,
            deck.AceOfSpades,
            deck.KingOfSpades
        };

        var sut = new FiveOfAKind();

        // act
        var result = sut.Qualify
        (
            new HandRankingArgs { Deck = deck, PlayerCards = playerCards }
        );

        // assert
        result.Qualifies.Should().BeFalse();
        result.HandCards.Should().BeEmpty();
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }
}

