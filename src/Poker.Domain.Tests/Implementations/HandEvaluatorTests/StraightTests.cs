namespace Poker.Domain.Tests.Implementations;

[ExcludeFromCodeCoverage]
public class StraightTests
{
    [Fact]
    public void SixHighStraight_Qualifies_AllCardsPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfSpades,
                Cards.FourOfClubs,
                Cards.ThreeOfHearts,
                Cards.TwoOfClubs
            },
            HandsToEvaluate = new()
            {
                Straights.SixHigh
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void SixHighStraight_Qualifies_WithJoker()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfSpades,
                Cards.FourOfClubs,
                Cards.ThreeOfHearts,
                Cards.CreateJoker()
            },
            HandsToEvaluate = new()
            {
                Straights.SixHigh
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void SixHighStraight_Eliminated_OneCardMissing()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfSpades,
                Cards.AceOfHearts,
                Cards.ThreeOfHearts,
                Cards.TwoOfClubs
            },
            HandsToEvaluate = new()
            {
                Straights.SixHigh
            },
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards = new()
            {
                Cards.FourOfSpades,
                Cards.FourOfHearts,
                Cards.FourOfClubs,
                Cards.FourOfDiamonds
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
    public void SixHighStraight_Possible_OneCardRemaining()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfSpades,
                Cards.ThreeOfHearts,
                Cards.TwoOfClubs
            },
            HandsToEvaluate = new()
            {
                Straights.SixHigh
            },
            RemainingCardCount = 1
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Possible);
    }
}
