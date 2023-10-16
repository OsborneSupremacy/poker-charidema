﻿namespace Poker.Domain.Tests.Implementations;

[ExcludeFromCodeCoverage]
public class FullHouseTests
{
    [Fact]
    public void ThreesOverTwos_Qualifies_RequiredMatchesPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfHearts,
                Cards.ThreeOfSpades,
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            },
            HandToEvaluate = FullHouses.ThreesOverTwos,
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ThreesOverTwos_Qualifies_ThreeThreesOneTwoAndJokerPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfHearts,
                Cards.ThreeOfSpades,
                Cards.TwoOfClubs,
                Cards.CreateJoker()
            },
            HandToEvaluate = FullHouses.ThreesOverTwos,
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void ThreesOverTwos_Eliminated_RequiredMatchesAbsent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfSpades,
                Cards.ThreeOfClubs,
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            },
            HandToEvaluate = FullHouses.ThreesOverTwos,
            RemainingCardCount = 0
        };

        List<HandSegment> expectedOutstanding = new()
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfDiamonds
                }
            }
        };

        // Act
        var response = HandEvaluator.Evaluate(request);
        var actualOutstanding = response
            .EvalulatedHandSegments
            .Where(x => x.MeetsRequirements == false)
            .Select(x => x.Outstanding)
            .ToList();

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Eliminated);
        actualOutstanding.Should().BeEquivalentTo(expectedOutstanding);
    }

    [Fact]
    public void ThreesOverTwos_Possible_OneRemainingCard()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfSpades,
                Cards.ThreeOfClubs,
                Cards.TwoOfClubs,
                Cards.TwoOfDiamonds
            },
            HandToEvaluate = FullHouses.ThreesOverTwos,
            RemainingCardCount = 1
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Possible);
    }
}
