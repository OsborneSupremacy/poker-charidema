namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class PairTests
{
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void PairOfTwos_Qualifies_TwoOrMorePresent(int twoCount)
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = Cards.All.Rank(Ranks.Two).Take(twoCount).ToList(),
            HandToEvaluate = Pairs.Twos,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void PairOfTwos_Qualifies_TwoAndJokerPresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.TwoOfClubs,
                Cards.CreateJoker()
            ],
            HandToEvaluate = Pairs.Twos,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void PairOfTwos_Eliminated_OneTwoPresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.TwoOfClubs,
                Cards.ThreeOfClubs
            ],
            HandToEvaluate = Pairs.Twos,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards =
            [
                Cards.TwoOfSpades,
                Cards.TwoOfHearts,
                Cards.TwoOfDiamonds
            ]
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);
        var actualOutstanding = response.EvaluatedHandSegments.Single().Outstanding;

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Fact]
    public void PairOfTwos_Possible_OneRemainingCard()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.TwoOfClubs,
                Cards.ThreeOfClubs
            ],
            HandToEvaluate = Pairs.Twos,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
