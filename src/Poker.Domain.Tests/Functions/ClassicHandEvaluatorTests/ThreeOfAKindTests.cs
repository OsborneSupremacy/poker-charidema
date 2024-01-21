namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class ThreeOfAKindTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    public void ThreeTwos_Qualifies_ThreeOrMorePresent(int threeCount)
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = Cards.All.WhereRank(Ranks.Two).Take(threeCount).ToList(),
            HandToEvaluate = ThreeOfAKind.Twos,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ThreeTwos_Qualifies_TwoThreesAndJokerPresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.ThreeOfClubs,
                Cards.ThreeOfDiamonds,
                Cards.CreateJoker()
            ],
            HandToEvaluate = ThreeOfAKind.Threes,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ThreeThrees_Eliminated_OneThreePresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = [Cards.ThreeOfClubs],
            HandToEvaluate = ThreeOfAKind.Threes,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 2,
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
            .First(x => x.Outstanding.RequiredCount > 0)
            .Outstanding;

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void ThreeThrees_Possible_OneOrMoreCardsRemaining(int cardsRemaining)
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.ThreeOfClubs,
                Cards.ThreeOfHearts
            ],
            HandToEvaluate = ThreeOfAKind.Threes,
            RemainingCardCount = cardsRemaining
        };

        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
