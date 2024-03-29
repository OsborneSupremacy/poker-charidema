﻿namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class HighCardTests
{
    [Fact]
    public void AceHigh_Qualifies_AcePresent()
    {
        // Arrange
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.AceOfClubs,
                Cards.KingOfClubs
            ],
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
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards =
            [
                Cards.AceOfClubs,
                Cards.CreateJoker()
            ],
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
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = [Cards.KingOfClubs],
            HandToEvaluate = HighCards.Ace,
            RemainingCardCount = 0
        };

        HandSegment expectedOutstanding = new()
        {
            RequiredCount = 1,
            EligibleCards =
            [
                Cards.AceOfSpades,
                Cards.AceOfHearts,
                Cards.AceOfClubs,
                Cards.AceOfDiamonds
            ]
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
        EvaluateHandRequest request = new()
        {
            Player = Players.Empty,
            Cards = [],
            HandToEvaluate = HighCards.Ace,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
