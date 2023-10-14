using System.Runtime.InteropServices;

namespace Poker.Domain.Tests.Implementations;

[ExcludeFromCodeCoverage]
public class ThreeOfAKindTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    public void ThreeTwos_Qualifies_ThreeOrMorePresent(int threeCount)
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = Cards.All.WhereRank(Ranks.Two).Take(threeCount).ToList(),
            HandsToEvaluate = new()
            {
                ThreeOfAKind.Twos
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ThreeTwos_Qualifies_TwoThreesAndJokerPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfClubs,
                Cards.ThreeOfDiamonds,
                Cards.CreateJoker()
            },
            HandsToEvaluate = new()
            {
                ThreeOfAKind.Threes
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ThreeThrees_Eliminated_OneThreePresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfClubs
            },
            HandsToEvaluate = new()
            {
                ThreeOfAKind.Threes
            },
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 2,
            EligibleCards = new()
            {
                Cards.ThreeOfHearts,
                Cards.ThreeOfSpades,
                Cards.ThreeOfDiamonds
            }
        };

        // Act
        var response = HandEvaluator.Evaluate(request);
        var actualOutstanding = response
            .Single()
            .EvalulatedHandSegments
            .Where(x => x.Outstanding.RequiredCount > 0)
            .First()
            .Outstanding;

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void ThreeThrees_Possible_OneOrMoreCardsemaining(int cardsRemaining)
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfClubs,
                Cards.ThreeOfHearts
            },
            HandsToEvaluate = new()
            {
                ThreeOfAKind.Threes
            },
            RemainingCardCount = cardsRemaining
        };

        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Possible);
    }
}
