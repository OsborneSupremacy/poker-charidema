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
            HandsToEvaluate = new()
            {
                TwoPair.ThreesOverTwos
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
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
            HandsToEvaluate = new()
            {
                TwoPair.ThreesOverTwos
            },
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
            HandsToEvaluate = new()
            {
                TwoPair.ThreesOverTwos
            },
            RemainingCardCount = 1
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Possible);
    }
}
