namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class FullHouseTests
{
    [Fact]
    public void ThreesOverTwos_Qualifies_RequiredMatchesPresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Participant = Participants.Empty,
            Cards =
            [
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfHearts,
                Cards.ThreeOfSpades,
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            ],
            HandToEvaluate = FullHouses.ThreesOverTwos,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ThreesOverTwos_Qualifies_ThreeThreesOneTwoAndJokerPresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Participant = Participants.Empty,
            Cards =
            [
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfHearts,
                Cards.ThreeOfSpades,
                Cards.TwoOfClubs,
                Cards.CreateJoker()
            ],
            HandToEvaluate = FullHouses.ThreesOverTwos,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ThreesOverTwos_Eliminated_RequiredMatchesAbsent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Participant = Participants.Empty,
            Cards =
            [
                Cards.ThreeOfSpades,
                Cards.ThreeOfClubs,
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            ],
            HandToEvaluate = FullHouses.ThreesOverTwos,
            RemainingCardCount = 0
        };

        List<HandSegment> expectedOutstanding =
        [
            new() { RequiredCount = 1, EligibleCards = [Cards.ThreeOfHearts, Cards.ThreeOfDiamonds] }
        ];

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);
        var actualOutstanding = response
            .EvaluatedHandSegments
            .Where(x => x.MeetsRequirements == false)
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
            Participant = Participants.Empty,
            Cards =
            [
                Cards.ThreeOfSpades,
                Cards.ThreeOfClubs,
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            ],
            HandToEvaluate = FullHouses.ThreesOverTwos,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
