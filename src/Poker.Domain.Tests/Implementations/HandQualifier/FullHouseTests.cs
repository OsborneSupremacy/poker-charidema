namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FullHouseTests
{
    [Fact]
    public void Qualify_True_When_FullHouse_Exist()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.TwoOfHearts,
            Cards.TwoOfDiamonds,
            Cards.TwoOfSpades,
            Cards.FourOfDiamonds,
            Cards.FourOfHearts
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.FullHouse
        };

        // act
        var result = HandQualifierDelegates.FullHouseHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Qualifies);
        result.HandCards.Should().BeEquivalentTo(playerCards);
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_False_When_No_FullHouse_Exists()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.TwoOfHearts,
            Cards.TwoOfDiamonds,
            Cards.TwoOfSpades,
            Cards.FourOfDiamonds,
            Cards.FiveOfDiamonds
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.FullHouse
        };

        // act
        var result = HandQualifierDelegates.FullHouseHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
    }
}
