﻿namespace Poker.Domain.Tests.Implementations;

public class PairTests
{
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void PairOfTwos_Qualifies_TwoPlusPresent(int twoCount)
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = Cards.All.WhereRank(Ranks.Two).Take(twoCount).ToList(),
            HandsToEvaluate = new()
            {
                Pairs.PairOfTwos
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

    [Fact]
    public void PairOfTwos_Eliminated_OneTwoPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.ThreeOfClubs
            },
            HandsToEvaluate = new()
            {
                Pairs.PairOfTwos
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Eliminated);
    }

    [Fact]
    public void PairOfTwos_Possible_OneRemainingCard()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.TwoOfClubs,
                Cards.ThreeOfClubs
            },
            HandsToEvaluate = new()
            {
                Pairs.PairOfTwos
            },
            RemainingCardCount = 1
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Possible);
    }
}
