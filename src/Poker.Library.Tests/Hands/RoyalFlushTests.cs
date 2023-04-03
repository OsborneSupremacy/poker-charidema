using Poker.Library.Hands;

namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]

public class RoyalFlushTests
{
    [Fact]
    public void Qualify_True_When_RoyalFlus_Exists()
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

        var sut = new RoyalFlush();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(playerCards);
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_False_When_StraightFlush_But_No_RoyalFlush_Exists()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.KingOfSpades,
            deck.QueenOfSpades,
            deck.JackOfSpades,
            deck.TenOfSpades,
            deck.NineOfSpades
        };

        var sut = new RoyalFlush();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeFalse();
    }
}
