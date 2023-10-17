using Poker.Domain.Functions.Classic;

namespace Poker.Domain.Tests.Implementations;

[ExcludeFromCodeCoverage]
public class RoyalFlushTests
{
    [Fact]
    public void RoyalFlush_Qualifies_AllCardsPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.AceOfClubs,
                Cards.KingOfClubs,
                Cards.QueenOfClubs,
                Cards.JackOfClubs,
                Cards.TenOfClubs
            },
            HandToEvaluate = RoyalFlushes.Clubs,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void RoyalFlush_Qualifies_WithJoker()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.AceOfClubs,
                Cards.KingOfClubs,
                Cards.QueenOfClubs,
                Cards.JackOfClubs,
                Cards.CreateJoker()
            },
            HandToEvaluate = RoyalFlushes.Clubs,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void RoyalFlush_Eliminated_OneCardMissing()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TenOfClubs,
                Cards.KingOfClubs,
                Cards.QueenOfClubs,
                Cards.JackOfClubs,
                Cards.NineOfClubs
            },
            HandToEvaluate = RoyalFlushes.Clubs,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards = new()
            {
                Cards.AceOfClubs
            }
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);
        var actualOutstanding = response
            .EvalulatedHandSegments
            .Single()
            .Outstanding;

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Fact]
    public void RoyalFlush_Possible_OneCardRemaining()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.KingOfClubs,
                Cards.QueenOfClubs,
                Cards.JackOfClubs,
                Cards.TenOfClubs
            },
            HandToEvaluate = RoyalFlushes.Clubs,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
