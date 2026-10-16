namespace Poker.Domain.Tests.Functions;

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
                Participant = Participants.Empty,
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
                Participant = new()
                {
                    Automaton = true,
                    BeginningStack = 100,
                    Stack = 100,
                    Folded = false,
                    Busted = false,
                    Id = Guid.NewGuid(),
                    Name = "Test Participant",
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

    [Fact]
    public void Evaluate_HigherTwoPairReturned_ThreePairsPresent()
    {
        // Arrange
        var participant = Participants.Empty with
        {
            CardsInPlay =
            [
                Cards.AceOfSpades.DealFaceDownToPlayer(),
                Cards.AceOfClubs.DealFaceDownToPlayer(),
                Cards.KingOfClubs.DealFaceDownToPlayer(),
                Cards.KingOfDiamonds.DealFaceDownToPlayer(),
                Cards.TwoOfClubs.DealFaceDownToPlayer(),
                Cards.TwoOfHearts.DealFaceDownToPlayer(),
                Cards.SevenOfHearts.DealFaceDownToPlayer()
            ]
        };

        // Act
        var response = DefaultBestHandEvaluator.Evaluate
        (
            new BestHandRequest
            {
                Participant = participant,
                RemainingCardCount = 0,
                HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
                HandEvaluator = ClassicHandEvaluator.Evaluate
            }
        );

        // Assert
        response.Hand.Should().Be(TwoPair.AcesOverKings);
    }

    [Fact]
    public void Evaluate_HigherFullHouseReturned_ThreeOfAKindAndTwoPairsPresent()
    {
        // Arrange
        var participant = Participants.Empty with
        {
            CardsInPlay =
            [
                Cards.AceOfSpades.DealFaceDownToPlayer(),
                Cards.AceOfClubs.DealFaceDownToPlayer(),
                Cards.AceOfHearts.DealFaceDownToPlayer(),
                Cards.KingOfClubs.DealFaceDownToPlayer(),
                Cards.KingOfDiamonds.DealFaceDownToPlayer(),
                Cards.TwoOfClubs.DealFaceDownToPlayer(),
                Cards.TwoOfHearts.DealFaceDownToPlayer()
            ]
        };

        // Act
        var response = DefaultBestHandEvaluator.Evaluate
        (
            new BestHandRequest
            {
                Participant = participant,
                RemainingCardCount = 0,
                HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
                HandEvaluator = ClassicHandEvaluator.Evaluate
            }
        );

        // Assert
        response.Hand.Should().Be(FullHouses.AcesOverKings);
    }
}
