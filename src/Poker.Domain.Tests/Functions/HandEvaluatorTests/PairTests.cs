using System.Runtime.InteropServices;
using Poker.Domain.Functions;

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
            HandsToEvaluate = new()
            {
                Pairs.Twos
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
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
            HandsToEvaluate = new()
            {
                Pairs.Twos
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
                Pairs.Twos
            },
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
        var response = HandEvaluator.Evaluate(request);
        var actualOutstanding = response.Single().EvalulatedHandSegments.Single().Outstanding;

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Eliminated);
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
            HandsToEvaluate = new()
            {
                Pairs.Twos
            },
            RemainingCardCount = 1
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Possible);
    }
}
