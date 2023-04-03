using Poker.Library.Hands;

namespace Poker.Library.Tests.Hands;

[ExcludeFromCodeCoverage]
public class StraightFlushTests
{
    [Fact]
    public void Qualify_True_When_StraightFlush_Exists()
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

        var sut = new StraightFlush();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeTrue();
        result.HandCards.Should().BeEquivalentTo(playerCards);
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_False_When_Straight_But_No_Flush_Exists()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.KingOfSpades,
            deck.QueenOfSpades,
            deck.JackOfSpades,
            deck.TenOfSpades,
            deck.NineOfClubs
        };

        var sut = new StraightFlush();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeFalse();
    }

    [Fact]
    public void Qualify_False_When_Flush_But_No_Straight_Exists()
    {
        // arrange
        Classic.Deck deck = new();

        List<ICard> playerCards = new() {
            deck.KingOfSpades,
            deck.QueenOfSpades,
            deck.JackOfSpades,
            deck.TenOfSpades,
            deck.EightOfSpades
        };

        var sut = new StraightFlush();

        // act
        var result = sut.Qualify(new HandRankingArgs { Deck = deck, PlayerCards = playerCards });

        // assert
        result.Qualifies.Should().BeFalse();
    }
}
