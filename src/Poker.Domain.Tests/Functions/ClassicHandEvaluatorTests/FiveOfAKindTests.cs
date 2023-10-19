﻿using Poker.Domain.Functions.Classic;

namespace Poker.Domain.Tests.Functions.ClassicHandEvaluatorTests;

[ExcludeFromCodeCoverage]
public class FiveOfAKindTests
{
    [Fact]
    public void FiveThrees_Qualifies_FourThreesAndJokerPresent()
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfClubs,
                Cards.ThreeOfDiamonds,
                Cards.ThreeOfSpades,
                Cards.ThreeOfHearts,
                Cards.CreateJoker()
            },
            HandToEvaluate = FiveOfAKind.Threes,
            RemainingCardCount = 0
        };

        // Act
        var response = ClassicHandEvaluator.Evaluate(request);

        // Assert
        response.HandQualification.Should().Be(HandQualifications.Qualifies);
    }

}
