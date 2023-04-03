using Poker.Library.Hands;

namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class FourOfAKindTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Four_Of_A_Kind()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.AceOfHearts,
            deck.AceOfDiamonds,
            deck.AceOfClubs,
            deck.AceOfSpades,
            deck.NineOfHearts
        };

        var sut = new FourOfAKind();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(new List<ICard>()
        {
            deck.AceOfHearts,
            deck.AceOfDiamonds,
            deck.AceOfClubs,
            deck.AceOfSpades
        });
        result.Kickers.Should().BeEquivalentTo(new List<ICard>() { deck.NineOfHearts });
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Four_Of_A_Kind()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.AceOfHearts,
            deck.AceOfDiamonds,
            deck.AceOfClubs,
            deck.KingOfSpades,
            deck.NineOfHearts
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

