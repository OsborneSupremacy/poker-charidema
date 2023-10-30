namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class StraightFlushTests
{
    [Fact]
    public void SixHighStraightFlush_Qualifies_AllCardsPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfClubs,
                Cards.FourOfClubs,
                Cards.ThreeOfClubs,
                Cards.TwoOfClubs
            },
            HandToEvaluate = StraightFlushes.SixHighClubs,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void SixHighStraightFlush_Qualifies_WithJoker()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfClubs,
                Cards.FourOfClubs,
                Cards.ThreeOfClubs,
                Cards.CreateJoker()
            },
            HandToEvaluate = StraightFlushes.SixHighClubs,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void SixHighStraightFlush_Eliminated_OneCardMissing()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfClubs,
                Cards.FourOfClubs,
                Cards.ThreeOfClubs
            },
            HandToEvaluate = StraightFlushes.SixHighClubs,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards = new()
            {
                Cards.TwoOfClubs
            }
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
    public void SixHighStraightFlush_Possible_OneCardRemaining()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfClubs,
                Cards.FourOfClubs,
                Cards.ThreeOfClubs

            },
            HandToEvaluate = StraightFlushes.SixHighClubs,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
