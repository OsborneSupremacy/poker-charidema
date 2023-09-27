using Poker.Domain.Extensions;

namespace Poker.Domain.Tests.Utility;

public record HandQualifierTestFixtureRequest
{
    public required Hand Hand { get; init; }

    public required uint RemainingCards { get; init; }

    public required HandQualifications ExpectedHandQualification { get; init; }
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

    private readonly HandQualifierTestFixtureRequest _request;

    private ExpectedAssessment _expectedAssessment = ExpectedAssessment.HandCard;

    public HandQualifications ExpectedHandQualification = HandQualifications.Qualifies;

    public List<Card> ExpectedHandCards = new();

    public List<Card> ExpectedKickers = new();

    public List<Card> ExpectedDeadCards = new();

    public HandQualifierTestFixture(HandQualifierTestFixtureRequest request)
    {
        _testCards = new List<TestCard>();
        _request = request;
        ExpectedHandQualification = request.ExpectedHandQualification;
    }

    public HandQualifierTestFixture ExpectedInHand(Action<HandQualifierTestFixture> configureHand)
    {
        _expectedAssessment = ExpectedAssessment.HandCard;
        configureHand(this);
        return this;
    }

    public HandQualifierTestFixture ExpectedInKicker(Action<HandQualifierTestFixture> configureHand)
    {
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

    public QualifiedHandResponse Execute()
    {
        ExpectedHandCards = _testCards
            .Where(x => x.ExpectedAssessment == ExpectedAssessment.HandCard)
            .Select(x => x.Card)
            .ToList();

        ExpectedKickers = _testCards
            .Where(x => x.ExpectedAssessment == ExpectedAssessment.Kicker)
            .Select(x => x.Card)
            .ToList();

        ExpectedDeadCards = _testCards
            .Where(x => x.ExpectedAssessment == ExpectedAssessment.DeadCard)
            .Select(x => x.Card)
            .ToList();

        return _request.Hand.HandQualifier(
            new QualifiedHandRequest
            {
                Cards = _testCards
                    .Select(x => x.Card)
                    .WithoutImpersonation()
                    .ToList(),
                RemainingCardCount = _request.RemainingCards,
                Hand = _request.Hand
            }
        );
    }
}

