namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FlushHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var potential = EvaluateFlushes(request);
        var complete = potential.WhereComplete();

        if(complete.Any())
            return request.Hand
                .ToQualifiedHand(
                    GetBestFlush(complete)
                );

        var best = GetBestFlush(
            potential
                .WithFewestNeededCards()
        );

        return request.Hand.ToUnqualifiedHand(
            best,
            best.EnoughRemainingCards()
        );
    };

    private static PotentialHandMessage GetBestFlush(
        IEnumerable<PotentialHandMessage> evalulated
        ) =>
        evalulated
            .OrderByDescending(x => x.HighRank.Value)
            .ThenByDescending(x => x.Suit.Priority)
            .First();

    private static List<PotentialHandMessage> EvaluateFlushes(QualifiedHandRequest request) =>
        Suits.All
            .OrderByDescending(s => s.Priority)
            .Select(suit => EvalulateFlush(request, suit))
            .ToList();

    private static PotentialHandMessage EvalulateFlush(
        QualifiedHandRequest request,
        Suit suit
        )
    {
        var playerCardsWithSuit = request
            .Cards
            .WhereSuit(suit)
            .ToList();

        var neededCount = GlobalConstants.HandSize - playerCardsWithSuit.Count;

        // add non-wildcards matching suit
        var contributingStandard = playerCardsWithSuit
            .OrderBySuit()
            .Take(GlobalConstants.HandSize)
            .ToList();

        // cards that can be impersonated, with suit in question
        var targets = Cards.All
            .WhereSuit(suit)
            .Except(playerCardsWithSuit)
            .OrderByRank()
            .Take(neededCount)
            .ToQueue();

        Queue<Card> wildCards = request.Cards
            .WhereWild()
            .Take(GlobalConstants.HandSize - contributingStandard.Count)
            .ToQueue();

        var contributingWild = wildCards
            .AssignWildCards(targets)
            .ToList();

        NeededCardMessageBuilder neededCardMessageBuilder = new();

        var stillNeededCount = GlobalConstants.HandSize
            - (contributingStandard.Count + contributingWild.Count);

        if (stillNeededCount > 0)
            neededCardMessageBuilder.WithCards(
                stillNeededCount.ToUint(),
                Cards.All.WhereSuit(suit)
            );

        return new PotentialHandMessage
        {
            HighRank = CardFunctions
                .GetMaxRank(contributingStandard, contributingWild),
            Suit = suit,
            Complete = stillNeededCount == 0,
            ContributingStandard = contributingStandard,
            ContributingWild = contributingWild,
            NonContributing = CardFunctions
                .GetNonContributingCards(request.Cards, contributingStandard, contributingWild),
            RemainingCardCount = request.RemainingCardCount,
            NeededCardMessage = neededCardMessageBuilder.Build()
        };
    }
}
