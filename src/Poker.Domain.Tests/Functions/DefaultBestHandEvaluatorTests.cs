﻿namespace Poker.Domain.Tests.Functions;

[ExcludeFromCodeCoverage]
public class DefaultBestHandEvaluatorTests
{
    [Fact]
    public void Evaluate_NoHand_NoCards()
    {
        // Arrange

        // Act
        var response = DefaultBestHandEvaluator.Evaluate
        (
            new BestHandRequest
            {
                Player = Players.Empty,
                RemainingCardCount = 0,
                HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
                HandEvaluator = ClassicHandEvaluator.Evaluate
            }
        );

        // Assert
        response.Hand.Should().Be(NoHands.NoHand);
    }

    [Fact]
    public void Evaluate_TwoPairReturned_TwoPairPlusOtherPairsPresent()
    {
        // Arrange

        // Act
        var response = DefaultBestHandEvaluator.Evaluate
        (
            new BestHandRequest
            {
                Player = new()
                {
                    Automaton = true,
                    BeginningStack = 100,
                    Stack = 100,
                    Folded = false,
                    Busted = false,
                    Id = Guid.NewGuid(),
                    Name = "Test Player",
                    Stake = 0,
                    CardsInPlay =
                    [
                        Cards.AceOfSpades.DealFaceDownToPlayer(),
                        Cards.AceOfClubs.DealFaceDownToPlayer(),
                        Cards.KingOfClubs.DealFaceDownToPlayer(),
                        Cards.KingOfDiamonds.DealFaceDownToPlayer(),
                        Cards.QueenOfClubs.DealFaceDownToPlayer()
                    ]
                },
                RemainingCardCount = 0,
                HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
                HandEvaluator = ClassicHandEvaluator.Evaluate
            }
        );

        // Assert
        response.Hand.Should().Be(TwoPair.AcesOverKings);
    }
}
