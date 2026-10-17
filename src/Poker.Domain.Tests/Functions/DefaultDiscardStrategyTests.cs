using Poker.Domain.Implementations.Variants;

namespace Poker.Domain.Tests.Functions;

[ExcludeFromCodeCoverage]
public class DefaultDiscardStrategyTests
{
    private readonly Phase _drawPhase = FiveCardDraw.GetVariant().Phases
        .Single(p => p.PhaseType == PhaseType.Draw);

    private IReadOnlyList<Card> Select(params Card[] hand)
    {
        var participant = Participants.Empty with
        {
            Id = Guid.NewGuid(),
            Name = "One",
            CardsInPlay = hand.DealToPlayer(CardOrientation.FaceDown)
        };

        var bestHand = DefaultBestHandEvaluator.Evaluate(new BestHandRequest
        {
            Participant = participant,
            RemainingCardCount = 0,
            HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
            HandEvaluator = ClassicHandEvaluator.Evaluate
        });

        return DefaultDiscardStrategy.Select(new DiscardStrategyRequest
        {
            ParticipantHand = bestHand.ToPlayerHand(),
            Phase = _drawPhase
        });
    }

    [Fact]
    public void Select_DiscardsThree_Pair()
    {
        // Act
        var discards = Select(
            Cards.KingOfSpades, Cards.KingOfHearts, Cards.TwoOfClubs, Cards.SevenOfHearts, Cards.NineOfDiamonds);

        // Assert
        discards.Should().BeEquivalentTo([Cards.TwoOfClubs, Cards.SevenOfHearts, Cards.NineOfDiamonds]);
    }

    [Fact]
    public void Select_DiscardsFourAndKeepsAce_AceHigh()
    {
        // Act
        var discards = Select(
            Cards.AceOfSpades, Cards.TwoOfClubs, Cards.FiveOfHearts, Cards.SevenOfHearts, Cards.NineOfDiamonds);

        // Assert
        discards.Should().BeEquivalentTo(
            [Cards.TwoOfClubs, Cards.FiveOfHearts, Cards.SevenOfHearts, Cards.NineOfDiamonds]);
    }

    [Fact]
    public void Select_DiscardsThreeLowest_KingHigh()
    {
        // Act
        var discards = Select(
            Cards.KingOfSpades, Cards.TwoOfClubs, Cards.FiveOfHearts, Cards.SevenOfHearts, Cards.NineOfDiamonds);

        // Assert
        discards.Should().BeEquivalentTo([Cards.TwoOfClubs, Cards.FiveOfHearts, Cards.SevenOfHearts]);
    }

    [Fact]
    public void Select_DiscardsKicker_TwoPair()
    {
        // Act
        var discards = Select(
            Cards.KingOfSpades, Cards.KingOfHearts, Cards.TwoOfClubs, Cards.TwoOfHearts, Cards.NineOfDiamonds);

        // Assert
        discards.Should().Equal(Cards.NineOfDiamonds);
    }

    [Fact]
    public void Select_StandsPat_Straight()
    {
        // Act
        var discards = Select(
            Cards.FiveOfSpades, Cards.SixOfHearts, Cards.SevenOfClubs, Cards.EightOfHearts, Cards.NineOfDiamonds);

        // Assert
        discards.Should().BeEmpty();
    }
}
