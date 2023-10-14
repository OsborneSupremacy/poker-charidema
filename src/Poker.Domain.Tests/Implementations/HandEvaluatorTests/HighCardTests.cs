namespace Poker.Domain.Tests.Implementations;

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
            HandsToEvaluate = new()
            {
                HighCards.Ace
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
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
            HandsToEvaluate = new()
            {
                HighCards.Ace
            },
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList()
        };

        // Act
        var response = HandEvaluator.Evaluate(request);
        var actualOutstanding = response.Single().EvalulatedHandSegments.Single().Outstanding;

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Fact]
    public void AceHigh_Possible_OneRemainingCard()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new(),
            HandsToEvaluate = new()
            {
                HighCards.Ace
            },
            RemainingCardCount = 1
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Possible);
    }
}
