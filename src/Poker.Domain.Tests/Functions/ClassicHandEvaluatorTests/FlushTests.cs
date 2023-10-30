namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class FlushTests
{
    [Fact]
    public void ClubsFlush_Qualifies_FiveClubsPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.FiveOfClubs,
                Cards.SevenOfClubs,
                Cards.JackOfClubs,
                Cards.AceOfClubs
            },
            HandToEvaluate = Flushes.Clubs,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ClubsFlush_Qualifies_FourClubsWithJoker()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.FiveOfClubs,
                Cards.SevenOfClubs,
                Cards.CreateJoker(),
                Cards.AceOfClubs
            },
            HandToEvaluate = Flushes.Clubs,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ClubsFlush_Eliminated_OneCardMissing()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.FiveOfClubs,
                Cards.SevenOfClubs,
                Cards.JackOfClubs,
                Cards.AceOfDiamonds
            },
            HandToEvaluate = Flushes.Clubs,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards = new()
            {
                Cards.ThreeOfClubs,
                Cards.FourOfClubs,
                Cards.SixOfClubs,
                Cards.EightOfClubs,
                Cards.NineOfClubs,
                Cards.TenOfClubs,
                Cards.QueenOfClubs,
                Cards.KingOfClubs,
                Cards.AceOfClubs
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
    public void ClubsFlush_Possible_OneCardRemaining()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.FiveOfClubs,
                Cards.SevenOfClubs,
                Cards.JackOfClubs
            },
            HandToEvaluate = Flushes.Clubs,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
