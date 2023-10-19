﻿using Poker.Domain.Functions.Classic;

namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

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
            HandToEvaluate = Straights.SixHigh,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
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
            HandToEvaluate = Straights.SixHigh,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
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
            HandToEvaluate = Straights.SixHigh,
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
        var response = ClassicHandEvaluator.Evaluate(request);
        var actualOutstanding = response
            .EvaluatedHandSegments
            .Where(x => x.Outstanding.RequiredCount > 0)
            .Single()
            .Outstanding;

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Eliminated);
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
            HandToEvaluate = Straights.SixHigh,
            RemainingCardCount = 1
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
