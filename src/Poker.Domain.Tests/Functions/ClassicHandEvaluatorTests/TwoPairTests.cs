namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

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
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
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
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfHearts,
                Cards.TwoOfClubs,
                Cards.CreateJoker()
            ],
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
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.ThreeOfClubs,
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            ],
            HandToEvaluate = TwoPair.ThreesOverTwos,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards =
            [
                Cards.ThreeOfHearts,
                Cards.ThreeOfSpades,
                Cards.ThreeOfDiamonds
            ]
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);
        var actualOutstanding = response
            .EvaluatedHandSegments
            .Single(x => x.Outstanding.RequiredCount > 0)
            .Outstanding;

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Fact]
    public void ThreesOverTwos_Eliminated_NeitherPairPresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.ThreeOfClubs,
                Cards.TwoOfDiamonds
            ],
            HandToEvaluate = TwoPair.ThreesOverTwos,
            RemainingCardCount = 0
        };

        List<HandSegment> expectedOutstanding =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.ThreeOfHearts, Cards.ThreeOfSpades, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 1, EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs]
            }
        ];

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        var actualOutstanding = response
            .EvaluatedHandSegments
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
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.ThreeOfClubs,
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            ],
            HandToEvaluate = TwoPair.ThreesOverTwos,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
