namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class StraightTests
{
    [Fact]
    public void Qualify_True_When_Straight_Exists()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.KingOfSpades,
            Cards.QueenOfHearts,
            Cards.JackOfClubs,
            Cards.TenOfDiamonds,
            Cards.NineOfSpades
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.Straight
        };

        // act
        var result = HandQualifierDelegates.StraightHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Qualifies);
        result.HandCards.Should().BeEquivalentTo(playerCards);
        result.Kickers.Should().BeEmpty();
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_False_When_No_Straight_Exists()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.KingOfSpades,
            Cards.QueenOfHearts,
            Cards.JackOfClubs,
            Cards.TenOfDiamonds,
            Cards.EightOfSpades
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.Straight
        };

        // act
        var result = HandQualifierDelegates.StraightHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
    }
}
