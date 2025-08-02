namespace Poker.Domain.Tests.Functions;

[ExcludeFromCodeCoverage]
public class DefaultHandCollectionEvaluatorTests
{
    [Fact]
    public void Evaluate_NoHand_NoCards()
    {
        // Arrange
        EvaluateHandCollectionRequest request = new()
        {
            Participant = Participants.Empty,
            Cards = [],
            HandEvaluator = ClassicHandEvaluator.Evaluate,
            HandsToEvaluate = AllHands.All,
            RemainingCardCount = 0
        };

        // Act
        var response = DefaultHandCollectionEvaluator.Evaluate(request)
            .FirstOrDefault(h => h.HandQualification == HandQualifications.Qualifies);

        // Assert
        response.Should().NotBeNull();
        response!.Hand.Should().Be(NoHands.NoHand);
    }

    [Fact]
    public void Evaluate_HighCard_NoOtherHand()
    {
        // Arrange
        EvaluateHandCollectionRequest request = new()
        {
            Participant = Participants.Empty,
            Cards =
            [
                Cards.ThreeOfClubs,
                Cards.FourOfHearts,
                Cards.FiveOfDiamonds,
                Cards.EightOfDiamonds,
                Cards.TenOfSpades
            ],
            HandEvaluator = ClassicHandEvaluator.Evaluate,
            HandsToEvaluate = AllHands.All,
            RemainingCardCount = 0
        };

        // Act
        var response = DefaultHandCollectionEvaluator.Evaluate(request)
            .FirstOrDefault(h => h.HandQualification == HandQualifications.Qualifies);

        // Assert
        response.Should().NotBeNull();
        response!.Hand.Should().Be(HighCards.Ten);
    }

    [Fact]
    public void Evaluate_Pair_PairPresent()
    {
        // Arrange
        EvaluateHandCollectionRequest request = new()
        {
            Participant = Participants.Empty,
            Cards =
            [
                Cards.ThreeOfClubs,
                Cards.ThreeOfHearts,
                Cards.FiveOfDiamonds,
                Cards.EightOfDiamonds,
                Cards.TenOfSpades
            ],
            HandEvaluator = ClassicHandEvaluator.Evaluate,
            HandsToEvaluate = AllHands.All,
            RemainingCardCount = 0
        };

        // Act
        var response = DefaultHandCollectionEvaluator.Evaluate(request)
            .FirstOrDefault(h => h.HandQualification == HandQualifications.Qualifies);

        // Assert
        response.Should().NotBeNull();
        response!.Hand.Should().Be(Pairs.Threes);
    }

    [Fact]
    public void Evaluate_PairOfFours_PairOfFoursPresent()
    {
        // Arrange
        EvaluateHandCollectionRequest request = new()
        {
            Participant = Participants.Empty,
            Cards =
            [
                Cards.EightOfDiamonds,
                Cards.SixOfDiamonds,
                Cards.FourOfSpades,
                Cards.FourOfClubs,
                Cards.ThreeOfClubs
            ],
            HandEvaluator = ClassicHandEvaluator.Evaluate,
            HandsToEvaluate = AllHands.All,
            RemainingCardCount = 0
        };

        // Act
        var response = DefaultHandCollectionEvaluator.Evaluate(request)
            .FirstOrDefault(h => h.HandQualification == HandQualifications.Qualifies);

        // Assert
        response.Should().NotBeNull();
        response!.Hand.Should().Be(Pairs.Fours);
    }

    [Fact]
    public void Evaluate_KingHigh_KingIsBestCard()
    {
        // Arrange
        EvaluateHandCollectionRequest request = new()
        {
            Participant = Participants.Empty,
            Cards =
            [
                Cards.KingOfSpades,
                Cards.TenOfSpades,
                Cards.NineOfDiamonds,
                Cards.SevenOfClubs,
                Cards.SixOfHearts
            ],
            HandEvaluator = ClassicHandEvaluator.Evaluate,
            HandsToEvaluate = AllHands.All,
            RemainingCardCount = 0
        };

        // Act
        var response = DefaultHandCollectionEvaluator.Evaluate(request)
            .FirstOrDefault(h => h.HandQualification == HandQualifications.Qualifies);

        // Assert
        response.Should().NotBeNull();
        response!.Hand.Should().Be(HighCards.King);
    }
}
