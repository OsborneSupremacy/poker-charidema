namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class FourOfAKindTests
{
    [Fact]
    public void FourTwos_Qualifies_FourPresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = Cards.All.Rank(Ranks.Two).Take(4).ToList(),
            HandToEvaluate = FourOfAKind.Twos,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void FourThrees_Qualifies_ThreeThreesAndJokerPresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.ThreeOfClubs,
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfSpades,
                Cards.CreateJoker()
            ],
            HandToEvaluate = FourOfAKind.Threes,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void FourThrees_Eliminated_TwoThreesPresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.ThreeOfClubs,
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfSpades
            ],
            HandToEvaluate = FourOfAKind.Threes,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards = [Cards.ThreeOfHearts]
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
    public void FourThrees_Possible_OneOrMoreCardsRemaining(int cardsRemaining)
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.ThreeOfClubs,
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfSpades
            ],
            HandToEvaluate = FourOfAKind.Threes,
            RemainingCardCount = cardsRemaining
        };

        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
