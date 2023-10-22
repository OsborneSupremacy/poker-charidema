namespace Poker.Domain.Tests.Functions;

[ExcludeFromCodeCoverage]
public class DefaultHandCollectionEvaluatorTests
{
    [Fact]
    public void Evaluate_NoHand_NoCards()
    {
        // Arrange
        EvaluatedHandCollectionRequest request = new()
        {
            Cards = new()
            {
            },
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
        EvaluatedHandCollectionRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfClubs,
                Cards.FourOfHearts,
                Cards.FiveOfDiamonds,
                Cards.EightOfDiamonds,
                Cards.TenOfSpades
            },
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
        EvaluatedHandCollectionRequest request = new()
        {
            Cards = new()
            {
                Cards.ThreeOfClubs,
                Cards.ThreeOfHearts,
                Cards.FiveOfDiamonds,
                Cards.EightOfDiamonds,
                Cards.TenOfSpades
            },
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
}
