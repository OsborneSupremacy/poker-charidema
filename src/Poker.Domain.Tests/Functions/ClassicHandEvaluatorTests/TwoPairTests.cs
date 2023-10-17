using Poker.Domain.Functions.Classic;

namespace Poker.Domain.Tests.Implementations;

[ExcludeFromCodeCoverage]
public class TwoPairTests
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(2, 3)]
    [InlineData(3, 2)]
    public void ThreesOverTwos_Qualifies_TwoOrMorePresent(
        int threeCount,
        int twoCount
        )
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = Cards.All
                .WhereRank(Ranks.Two)
                .Take(twoCount)
                .Concat(
                    Cards.All
                        .WhereRank(Ranks.Three)
                        .Take(threeCount)
                )
                .ToList(),
            HandToEvaluate = TwoPair.ThreesOverTwos,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ThreesOverTwos_Qualifies_TwoThreesOneTwoAndJokerPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfHearts,
                Cards.TwoOfClubs,
                Cards.CreateJoker()
            },
            HandToEvaluate = TwoPair.ThreesOverTwos,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ThreesOverTwos_Eliminated_OneThreePresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfClubs,
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            },
            HandToEvaluate = TwoPair.ThreesOverTwos,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards = new()
            {
                Cards.ThreeOfHearts,
                Cards.ThreeOfSpades,
                Cards.ThreeOfDiamonds
            }
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);
        var actualOutstanding = response
            .EvalulatedHandSegments
            .Where(x => x.Outstanding.RequiredCount > 0)
            .Single()
            .Outstanding;

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Fact]
    public void ThreesOverTwos_Eliminated_NeitherPairPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfClubs,
                Cards.TwoOfDiamonds
            },
            HandToEvaluate = TwoPair.ThreesOverTwos,
            RemainingCardCount = 0
        };

        List<HandSegment> expectedOutstanding = new()
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs
                }
            }
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        var actualOutstanding = response
            .EvalulatedHandSegments
            .Select(x => x.Outstanding)
            .ToList();

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Fact]
    public void ThreesOverTwos_Possible_OneRemainingCard()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfClubs,
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            },
            HandToEvaluate = TwoPair.ThreesOverTwos,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
