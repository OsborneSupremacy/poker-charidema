using Poker.Domain.Extensions;

namespace Poker.Domain.Tests.Utility;

public record HandQualifierTestFixtureResponse
{
    public required HandQualifications ExpectedHandQualification { get; init; } 

    public required List<Card> ExpectedHandCards { get; init; }

    public required List<Card> ExpectedKickers { get; init; }

    public required List<Card> ExpectedDeadCards { get; init; }

    public required QualifiedHandResponse QualifiedHandResponse { get; init; }
}

public static class HandQualifierTestFixtureExtensions
{
    public static void ShouldBeAsExpected(
        this HandQualifierTestFixtureResponse response
        )
    {
        response.QualifiedHandResponse.HandQualification.Should().Be(response.ExpectedHandQualification);
        response.QualifiedHandResponse.HandCards.Should().BeEquivalentTo(response.ExpectedHandCards);
        response.QualifiedHandResponse.Kickers.Should().BeEquivalentTo(response.ExpectedKickers);
        response.QualifiedHandResponse.DeadCards.Should().BeEquivalentTo(response.ExpectedDeadCards);
    }
}

[ExcludeFromCodeCoverage]
public class HandQualifierTestFixture
{
    private enum ExpectedAssessment
    {
        HandCard,
        Kicker,
        DeadCard
    }

    private record TestCard
    {
        public required ExpectedAssessment ExpectedAssessment { get; init; }

        public required Card Card { get; init; }
    }

    private readonly List<TestCard> _testCards;

    private Hand _hand;

    private uint _remainingCards = 0;

    private ExpectedAssessment _expectedAssessment = ExpectedAssessment.HandCard;

    public HandQualifications ExpectedHandQualification = HandQualifications.Qualifies;

    public HandQualifierTestFixture()
    {
        _testCards = new List<TestCard>();
        _hand = Hands.NoHand;
    }

    public HandQualifierTestFixture For(Hand hand)
    {
        _hand = hand;
        return this;
    }

    public HandQualifierTestFixture WithCardsRemaining(uint remainingCards)
    {

        _remainingCards = remainingCards;
        return this;
    }

    public HandQualifierTestFixture ExpectedInHand(Action<HandQualifierTestFixture> configureHand)
    {
        ExpectedHandQualification = HandQualifications.Qualifies;
        _expectedAssessment = ExpectedAssessment.HandCard;
        configureHand(this);
        return this;
    }

    public HandQualifierTestFixture ExpectedInKicker(Action<HandQualifierTestFixture> configureHand)
    {
        ExpectedHandQualification = HandQualifications.Qualifies;
        _expectedAssessment = ExpectedAssessment.Kicker;
        configureHand(this);
        return this;
    }

    public HandQualifierTestFixture ExpectedInDeadCards(Action<HandQualifierTestFixture> configureHand)
    {
        _expectedAssessment = ExpectedAssessment.DeadCard;
        configureHand(this);
        return this;
    }

    public HandQualifierTestFixture With(Card card)
    {
        _testCards.Add
            (
                new()
                {
                    ExpectedAssessment = _expectedAssessment,
                    Card = card
                }
            );
        return this;
    }

    public HandQualifierTestFixture With(IEnumerable<Card> cards)
    {
        _testCards.AddRange
            (
                cards
                    .Select(x => new TestCard
                    {
                        Card = x,
                        ExpectedAssessment = _expectedAssessment
                    })
            );
        return this;
    }

    public HandQualifierTestFixture WithRange(
        Suit suit,
        Rank startRank,
        Rank endRank
        )
    {
        _testCards.AddRange
            (
                Cards.All
                .WhereSuit(suit)
                .WhereNotWild()
                .Where(x => x.Rank.Value >= startRank.Value)
                .Where(x => x.Rank.Value <= endRank.Value)
                .Select(x => new TestCard { Card = x, ExpectedAssessment = _expectedAssessment })
            );
        return this;
    }

    public HandQualifierTestFixtureResponse Execute()
    {
        var expectedHandCards = _testCards
            .Where(x => x.ExpectedAssessment == ExpectedAssessment.HandCard)
            .Select(x => x.Card)
            .OrderByPokerStandard()
            .ToList();

        var expectedKickers = _testCards
            .Where(x => x.ExpectedAssessment == ExpectedAssessment.Kicker)
            .Select(x => x.Card)
            .OrderByPokerStandard()
            .ToList();

        var expectedDeadCards = _testCards
            .Where(x => x.ExpectedAssessment == ExpectedAssessment.DeadCard)
            .Select(x => x.Card)
            .OrderByPokerStandard()
            .ToList();

        return new()
        {
            ExpectedHandQualification =
                expectedHandCards.Any()
                || expectedKickers.Any() ? HandQualifications.Qualifies : HandQualifications.Eliminated,

            ExpectedHandCards = expectedHandCards,

            ExpectedKickers = expectedKickers,

            ExpectedDeadCards = expectedDeadCards,

            QualifiedHandResponse = _hand.HandQualifier(
                new QualifiedHandRequest
                {
                    Cards = _testCards
                        .Select(x => x.Card)
                        .WithoutImpersonation()
                        .ToList(),
                    RemainingCardCount = _remainingCards,
                    Hand = _hand
                }
            )
        };
    }
}

