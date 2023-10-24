namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class HighCardTests
{
    [Fact]
    public void AceHigh_Qualifies_AcePresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.AceOfClubs,
                Cards.KingOfClubs
            },
            HandToEvaluate = HighCards.Ace,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void AceHigh_Qualifies_JokerPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.AceOfClubs,
                Cards.CreateJoker()
            },
            HandToEvaluate = HighCards.Ace,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void AceHigh_Eliminated_NonAcePresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.KingOfClubs
            },
            HandToEvaluate = HighCards.Ace,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);
        var actualOutstanding = response.EvaluatedHandSegments.Single().Outstanding;

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Fact]
    public void AceHigh_Possible_OneRemainingCard()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new(),
            HandToEvaluate = HighCards.Ace,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
