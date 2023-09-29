namespace Poker.Domain.Extensions;

public static class CardCollectionExtensions
{
    public static List<Card> GetMatchingRankHand(
        this List<Card> input,
        Rank rank,
        int requiredCount
    ) =>
        input.AnyWild() switch
        {
            true => input.GetMatchingRankHandWithSomeWildCards(rank, requiredCount),
            false => input.GetMatchingRankHandWithNoWildCards(rank, requiredCount),
        };

    public static List<Card> GetMatchingRankHandWithNoWildCards(
        this List<Card> input,
        Rank rank,
        int requiredCount
        ) => input
            .WhereRank(rank)
            .OrderBySuit()
            .Take(requiredCount)
            .ToList();

    public static List<Card> GetMatchingRankHandWithSomeWildCards(
        this List<Card> input,
        Rank rank,
        int requiredCount
        )
    {
        Queue<Card> wildCards = input.WhereWild().ToQueue();

        var playerCardsWithRank = input.WhereRank(rank).ToList();
        var neededCount = requiredCount - playerCardsWithRank.Count;

        // add non-wildcards matching rank
        var cardsOut = playerCardsWithRank
            .OrderBySuit()
            .Take(requiredCount)
            .ToList();

        // cards that can be impersonated, with rank in question
        var targets = Cards
            .All
            .WhereRank(rank)
            .OrderBySuit()
            // if a card that the player is holding a the real version
            // of has to be impersonated, it should only be impersonated
            // after all other cards have been impersonated. This is mainly
            // an issue for 5-of-a-kind.
            .OrderBy(playerCardsWithRank.Contains)
            .Take(neededCount)
            .ToQueue();

        return cardsOut
            .AssignWildCards(wildCards, targets, requiredCount);
    }

    public static List<Card> AssignWildCards(
        this List<Card> cardsIn,
        Queue<Card> wildCards,
        Queue<Card> targets,
        int max
        )
    {
        var cardsOut = cardsIn;

        while (
            targets.Any()
            && wildCards.Any()
            && cardsOut.Count < max
            )
            cardsOut.Add(
                wildCards.Dequeue() with { Impersonating = targets.Dequeue() }
            );

        return cardsOut;
    }

    public static List<Card> GetKickers(
        this List<Card> input,
        List<Card> handCards) =>
            input
                .WithoutImpersonation()
                .Except(handCards.WithoutImpersonation())
                .OrderByPokerStandard()
                .Take(GlobalConstants.HandSize - handCards.Count)
                .ToList();

    public static List<Card> GetDeadCards(
        this List<Card> input,
        List<Card> handCards,
        List<Card> kickers
        ) =>
        input.WithoutImpersonation()
            .Except(handCards.WithoutImpersonation())
            .Except(kickers.WithoutImpersonation())
            .ToList();

    public static bool HasCountOfMatchingRank(this List<Card> input, Rank rank, uint count) =>
        input.WhereRank(rank).Count() >= count;

    public static bool HasCountOfMatchingRankOrWild(this List<Card> input, Rank rank, uint count) =>
        input.WhereRanksOrIsWild(rank).Count() >= count;

    public static bool AnyWild(this List<Card> input) =>
        input.WhereWild().Any();

    public static int WildCount(this List<Card> input) =>
        input.WhereWild().Count();

    public static Rank GetBestMatchingRank(this List<Card> cards, uint count)
    {
        foreach (var rank in Ranks.All.OrderByPokerStandard())
            if (cards.HasCountOfMatchingRankOrWild(rank, count))
                return rank;
        return Ranks.Empty;
    }

    public static Rank GetMaxRank(this IEnumerable<Card> input)
    {
        var cards = input
            .Concat(
                input.SelectImpersonationTargets()
            )
            .ToList();

        return cards.Any() switch
        {
            true => cards
                .Where(c => c.Rank.Value == cards.Max(c => c.Rank.Value))
                .Select(c => c.Rank)
                .First(),
            false => Ranks.Empty
        };
    }

    public static string AggregateId(this List<Card> input) =>
        string.Join('|',
            input.OrderBy(x => x.Id).Select(x => x.Id.ToString())
        );
}
