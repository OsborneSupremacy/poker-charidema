namespace Poker.Domain.Tests.Implementations;

public class PairTests
{
    [Fact]
    public void PairOfTwos_Qualifies_TwoTwosPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            },
            HandsToEvaluate = new()
            {
                Pairs.PairOfTwos
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void PairOfTwos_Eliminated_OneTwoPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.ThreeOfClubs
            },
            HandsToEvaluate = new()
            {
                Pairs.PairOfTwos
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Eliminated);
    }

    [Fact]
    public void PairOfTwos_Possible_OneRemainingCard()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.ThreeOfClubs
            },
            HandsToEvaluate = new()
            {
                Pairs.PairOfTwos
            },
            RemainingCardCount = 1
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Possible);
    }
}
