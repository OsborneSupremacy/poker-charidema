namespace Poker.Domain.Tests.Utility;

public class HandBuilder
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

    private readonly List<TestCard> _cards;

    private ExpectedAssessment _expectedAssessment = ExpectedAssessment.HandCard;

    public HandBuilder()
    {
        _cards = new List<TestCard>();
    }

    public HandBuilder ExpectedInHand(Action<HandBuilder> configureHand)
    {
        _expectedAssessment = ExpectedAssessment.HandCard;
        configureHand(this);
        return this;
    }

    public HandBuilder ExpectedInKicker(Action<HandBuilder> configureHand)
    {
        _expectedAssessment = ExpectedAssessment.Kicker;
        configureHand(this);
        return this;
    }

    public HandBuilder ExpectedInDeadCards(Action<HandBuilder> configureHand)
    {
        _expectedAssessment = ExpectedAssessment.DeadCard;
        configureHand(this);
        return this;
    }

    public HandBuilder With(Card card)
    {
        _cards.Add
            (
                new() {
                    ExpectedAssessment = _expectedAssessment,
                    Card = card
                }
            );
        return this;
    }

    public HandBuilder With(IEnumerable<Card> cards)
    {
        _cards.AddRange
            (
                cards
                    .Select(x => new TestCard {
                        Card = x, ExpectedAssessment = _expectedAssessment
                    })
            );
        return this;
    }

    public HandBuilder WithRange(
        Suit suit,
        Rank startRank,
        Rank endRank
        )
    {
        _cards.AddRange
            (
                Cards.All
                .Where(x => x.Suit.Priority == suit.Priority)
                .Where(x => x.Rank.Value >= startRank.Value)
                .Where(x => x.Rank.Value <= endRank.Value)
                .Where(x => !x.IsWild)
                .Select(x => new TestCard { Card = x, ExpectedAssessment =  _expectedAssessment })
            );
        return this;
    }

    public List<Card> GetPlayerCards() =>
        _cards.Select(x => x.Card).ToList();

    public List<Card> GetExpectedHandCards() =>
        _cards
        .Where(x => x.ExpectedAssessment == ExpectedAssessment.HandCard)
        .Select(x => x.Card)
        .ToList();

    public List<Card> GetExpectedKickers() =>
        _cards
        .Where(x => x.ExpectedAssessment == ExpectedAssessment.Kicker)
        .Select(x => x.Card)
        .ToList();

    public List<Card> GetExpectedDeadCards() =>
        _cards
        .Where(x => x.ExpectedAssessment == ExpectedAssessment.DeadCard)
        .Select(x => x.Card)
        .ToList();
}

