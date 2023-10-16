using Poker.Domain.Functions;

namespace Poker.Domain.Tests.Implementations;

[ExcludeFromCodeCoverage]
public class StraightFlushTests
{
    [Fact]
    public void SixHighStraightFlush_Qualifies_AllCardsPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfClubs,
                Cards.FourOfClubs,
                Cards.ThreeOfClubs,
                Cards.TwoOfClubs
            },
            HandsToEvaluate = new()
            {
                StraightFlushes.SixHighClubs
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void SixHighStraightFlush_Qualifies_WithJoker()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfClubs,
                Cards.FourOfClubs,
                Cards.ThreeOfClubs,
                Cards.CreateJoker()
            },
            HandsToEvaluate = new()
            {
                StraightFlushes.SixHighClubs
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void SixHighStraightFlush_Eliminated_OneCardMissing()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfClubs,
                Cards.FourOfClubs,
                Cards.ThreeOfClubs
            },
            HandsToEvaluate = new()
            {
                StraightFlushes.SixHighClubs
            },
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
        var response = HandEvaluator.Evaluate(request);
        var actualOutstanding = response
            .Single()
            .EvalulatedHandSegments
            .Where(x => x.Outstanding.RequiredCount > 0)
            .Single()
            .Outstanding;

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Fact]
    public void SixHighStraightFlush_Possible_OneCardRemaining()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.SixOfClubs,
                Cards.FiveOfClubs,
                Cards.FourOfClubs,
                Cards.ThreeOfClubs

            },
            HandsToEvaluate = new()
            {
                StraightFlushes.SixHighClubs
            },
            RemainingCardCount = 1
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Possible);
    }
}
