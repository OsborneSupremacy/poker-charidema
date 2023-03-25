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
        Suit spades = new("Spades", 1);
        Suit hearts = new("Hearts", 1);

        List<Rank> spotCardRanks = new() { ace };
        List<Rank> faceCardRanks = new();
        List<Suit> suit = new() { spades, hearts };

        Deck expectedResult = new()
        {
            Cards = new List<ICard>()
            {
                new SpotCard() { 
                    Suit = spades,
                    Rank = ace,
                    CardOrientation = CardOrientations.Facedown
                },
                new SpotCard() {
                    Suit = hearts,
                    Rank = ace,
                    CardOrientation = CardOrientations.Facedown
                },
            }
        };

        DeckFactoryArgs inputs = new(spotCardRanks, faceCardRanks, suit);

        DeckFactory sut = new();
        
        // act
        var result = sut.Create(inputs);
        
        // assert
        result.Should().BeEquivalentTo(expectedResult);
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
        result.Cards.Where(x => x is FaceCard).Count().Should().Be(12);
        result.Cards.Distinct().Count().Should().Be(52);
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
        result.Cards.Distinct().Count().Should().Be(53);
        result.Cards.Where(x => x is FaceCard).Count().Should().Be(12);
        result.Cards.Where(x => x is Joker).Count().Should().Be(2);
    }
}