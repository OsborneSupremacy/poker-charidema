using Poker.Library.Hands;

namespace Poker.Service.Tests;

[ExcludeFromCodeCoverage]
public class HandRankingServiceTests
{
    [Fact]
    public void Return_Royal_Flush_When_Qualifies()
    {
        // arrange
        Library.Classic.Deck deck = new();

        HandRankingArgs args = new()
        {
            Deck = deck,
            PlayerCards = new()
            {
                deck.AceOfSpades,
                deck.KingOfSpades,
                deck.QueenOfSpades,
                deck.JackOfSpades,
                deck.TenOfSpades
            }
        };

        var sut = new HandRankingService();

        // act
        var result = sut.GetBest(args);

        // assert
        result.HandRanking.Should().BeOfType<RoyalFlush>();
    }

    [Fact]
    public void Return_FiveOfAKind_When_Qualifies()
    {
        // arrange
        Library.Classic.Deck deck = new(1);

        HandRankingArgs args = new()
        {
            Deck = deck,
            PlayerCards = new()
            {
                deck.AceOfSpades,
                deck.AceOfClubs,
                deck.AceOfDiamonds,
                deck.AceOfHearts,
                deck.Jokers.Single()
            }
        };

        var sut = new HandRankingService();

        // act
        var result = sut.GetBest(args);

        // assert
        result.HandRanking.Should().BeOfType<FiveOfAKind>();
    }

    [Fact]
    public void Return_FiveOfAKind_When_All_Wild()
    {
        // arrange
        Library.Classic.Deck deck = new(5);

        HandRankingArgs args = new()
        {
            Deck = deck,
            PlayerCards = new()
            {
                deck.Jokers.First(),
                deck.Jokers.Skip(1).First(),
                deck.Jokers.Skip(2).First(),
                deck.Jokers.Skip(3).First(),
                deck.Jokers.Skip(4).First(),
            }
        };

        var sut = new HandRankingService();

        // act
        var result = sut.GetBest(args);

        // assert
        result.HandRanking.Should().BeOfType<FiveOfAKind>();
    }

    [Fact]
    public void Return_HighCard_When_No_Other_Hand()
    {
        // arrange
        Library.Classic.Deck deck = new(0);

        HandRankingArgs args = new()
        {
            Deck = deck,
            PlayerCards = new()
            {
                deck.TwoOfHearts,
                deck.ThreeOfDiamonds,
                deck.FiveOfClubs,
                deck.SixOfSpades,
                deck.JackOfHearts,
            }
        };

        var sut = new HandRankingService();

        // act
        var result = sut.GetBest(args);

        // assert
        result.HandRanking.Should().BeOfType<HighCard>();
    }
}
