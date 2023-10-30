namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class RoyalFlushTests
{
    [Fact]
    public void RoyalFlush_Qualifies_AllCardsPresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
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
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
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
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
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
            .EvaluatedHandSegments
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
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
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
