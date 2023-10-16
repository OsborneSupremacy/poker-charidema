﻿namespace Poker.Domain.Tests.Implementations;

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
        var response = HandEvaluator.Evaluate(request);

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
        var response = HandEvaluator.Evaluate(request);

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
            EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList()
        };

        // Act
        var response = HandEvaluator.Evaluate(request);
        var actualOutstanding = response.EvalulatedHandSegments.Single().Outstanding;

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
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
