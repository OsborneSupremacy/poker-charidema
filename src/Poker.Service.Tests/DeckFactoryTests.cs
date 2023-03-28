using Poker.Library.Cards;

namespace Poker.Service.Tests;

[ExcludeFromCodeCoverage]
public class DeckFactoryTests
{
    [Fact]
    public void Create_Expected_Output_Simple_Case()
    {
        // arrange
        Rank ace = new("Ace", 14);
        Suit spades = new("Spades", 1, System.Drawing.Color.Black);
        Suit hearts = new("Hearts", 1, System.Drawing.Color.Red);

        List<Rank> spotCardRanks = new() { ace };
        List<Rank> faceCardRanks = new();
        List<Suit> suit = new() { spades, hearts };

        DeckFactoryArgs inputs = new(spotCardRanks, faceCardRanks, suit);

        DeckFactory sut = new();
        
        // act
        var result = sut.Create(inputs);
        
        // assert
        result.Cards.Count().Should().Be(2);
    }

    [Fact]
    public void Create_Expected_Count_Standard_Deck()
    {
        // arrange
        DeckFactoryArgs inputs = new(
            new RankFactory().CreateStandardSpotCardRanks(),
            new RankFactory().CreateStandardFaceCardRanks(),
            new SuitFactory().CreateStandard()
        );

        DeckFactory sut = new();

        // act
        var result = sut.Create(inputs);

        // assert
        result.Cards.Count.Should().Be(52);
        result.Cards.Where(x => x is Face).Count().Should().Be(12);
    }

    [Fact]
    public void Create_Expected_Count_Standard_Deck_With_Jokers()
    {
        // arrange
        DeckFactoryArgs inputs = new(
            new RankFactory().CreateStandardSpotCardRanks(),
            new RankFactory().CreateStandardFaceCardRanks(),
            new SuitFactory().CreateStandard(),
            2
        );

        DeckFactory sut = new();

        // act
        var result = sut.Create(inputs);

        // assert
        result.Cards.Count.Should().Be(54);
        result.Cards.Where(x => x is Face).Count().Should().Be(12);
        result.Cards.Where(x => x is Joker).Count().Should().Be(2);
    }
}