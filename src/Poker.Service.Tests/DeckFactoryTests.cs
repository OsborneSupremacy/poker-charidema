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

        List<Rank> ranks = new() { ace };
        List<Suit> suit = new() { spades, hearts };

        Deck expectedResult = new Deck() with
        {
            Cards = new List<Card>()
            {
                new Card() { 
                    Suit = spades,
                    Rank = ace,
                    CardOrientation = CardOrientations.Facedown
                },
                new Card() {
                    Suit = hearts,
                    Rank = ace,
                    CardOrientation = CardOrientations.Facedown
                },
            }
        };

        DeckFactoryInputs inputs = new(ranks, suit);

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
        DeckFactoryInputs inputs = new(
            new RankFactory().CreateStandard(),
            new SuitFactory().CreateStandard()
        );

        DeckFactory sut = new();

        // act
        var result = sut.Create(inputs);

        // assert
        result.Cards.Count().Should().Be(52);
        result.Cards.Distinct().Count().Should().Be(52);
    }
}