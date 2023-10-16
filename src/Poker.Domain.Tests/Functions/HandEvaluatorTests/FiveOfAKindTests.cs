using Poker.Domain.Functions;

namespace Poker.Domain.Tests.Implementations.HandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class FiveOfAKindTests
{
    [Fact]
    public void FiveThrees_Qualifies_FourThreesAndJokerPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfClubs,
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfSpades,
                Cards.ThreeOfHearts,
                Cards.CreateJoker()
            },
            HandsToEvaluate = new()
            {
                FiveOfAKind.Threes
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

}
