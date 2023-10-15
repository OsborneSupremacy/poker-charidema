namespace Poker.Domain.Tests.Implementations;

[ExcludeFromCodeCoverage]
public class FlushTests
{
    [Fact]
    public void ClubsFlush_Qualifies_FiveClubsPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.FiveOfClubs,
                Cards.SevenOfClubs,
                Cards.JackOfClubs,
                Cards.AceOfClubs
            },
            HandsToEvaluate = new()
            {
                Flushes.Clubs
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ClubsFlush_Qualifies_FourClubsWithJoker()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.FiveOfClubs,
                Cards.SevenOfClubs,
                Cards.CreateJoker(),
                Cards.AceOfClubs
            },
            HandsToEvaluate = new()
            {
                Flushes.Clubs
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ClubsFlush_Eliminated_OneCardMissing()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.FiveOfClubs,
                Cards.SevenOfClubs,
                Cards.JackOfClubs,
                Cards.AceOfDiamonds
            },
            HandsToEvaluate = new()
            {
                Flushes.Clubs
            },
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
    public void ClubsFlush_Possible_OneCardRemaining()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.FiveOfClubs,
                Cards.SevenOfClubs,
                Cards.JackOfClubs
            },
            HandsToEvaluate = new()
            {
                Flushes.Clubs
            },
            RemainingCardCount = 1
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Possible);
    }
}
