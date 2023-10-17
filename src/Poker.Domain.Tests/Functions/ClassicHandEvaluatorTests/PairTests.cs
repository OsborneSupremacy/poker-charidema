using Poker.Domain.Functions.Classic;

namespace Poker.Domain.Tests.Implementations;

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
        EvaluatedHandRequest request = new()
        {
            Cards = Cards.All.WhereRank(Ranks.Two).Take(twoCount).ToList(),
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
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.CreateJoker()
            },
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
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.ThreeOfClubs
            },
            HandToEvaluate = Pairs.Twos,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards = new()
            {
                Cards.TwoOfSpades,
                Cards.TwoOfHearts,
                Cards.TwoOfDiamonds
            }
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);
        var actualOutstanding = response.EvalulatedHandSegments.Single().Outstanding;

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
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
            HandToEvaluate = Pairs.Twos,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
