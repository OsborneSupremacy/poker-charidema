using Poker.Domain.Classic;

namespace Poker.Domain.Extensions;

public static class CardExtensions
{
    public static string ToStandardNotation(this Card input) =>
        $"{input.GetRankId()}{input.GetSymbol()}";

    public static string GetRankId(this Card input) =>
        input.CardType switch
        {
            CardTypes.Joker => "*",
            CardTypes.Ace => input.Rank!.Name[..1],
            CardTypes.Face => input.Rank!.Name[..1],
            CardTypes.Spot => input.Rank!.Value.ToString(),
           _ => throw new NotSupportedException(),
        };

    public static string GetSymbol(this Card input) =>
        input.Suit?.Name[..1].ToString().ToLowerInvariant() ?? string.Empty;

    public static bool MatchesRank(this Card input, Rank rank) =>
        input.Rank.Value == rank.Value;

    public static bool SatisfiesRank(this Card input, Rank minRank) =>
        input.Rank.Value >= minRank.Value;

    public static bool MatchesRankOrIsWild(this Card input, Rank rank) =>
        input.MatchesRank(rank)
        || input.IsWild;

    public static bool SatisfiesRankOrIsWild(this Card input, Rank minRank) =>
        input.SatisfiesRank(minRank)
        || input.IsWild;

    public static bool MatchesSuit(this Card input, Suit suit) =>
        input.Suit.Priority == suit.Priority;

    public static bool MatchesSuitOrIsWild(this Card input, Suit suit) =>
        input.MatchesSuit(suit)
        || input.IsWild;

    public static bool HasCountOfMatchingRank(this List<Card> input, Rank rank, uint count) =>
        input.Count(x => x.MatchesRank(rank)) >= count;

    public static bool HasCountOfMatchingRankOrWild(this List<Card> input, Rank rank, uint count) =>
        input.Count(x => x.MatchesRankOrIsWild(rank)) >= count;

    public static bool AnyWild(this List<Card> input) =>
        input.Where(x => x.IsWild).Any();

    public static int WildCount(this List<Card> input) =>
        input.Where(x => x.IsWild).Count();

    public static Rank GetBestMatchingRank(this List<Card> cards, uint count)
    {
        foreach(var rank in Ranks.All.OrderByDescending(r => r.Value))
            if (cards.HasCountOfMatchingRankOrWild(rank, count))
                return rank;
        return Ranks.Empty;
    }

    public static List<Card> GetMatchingRank(this List<Card> input, Rank rank) =>
        input.Where(x => x.MatchesRank(rank)).ToList();

    public static List<Card> GetWild(this List<Card> input) =>
        input.Where(x => x.IsWild).ToList();

    public static List<Card> GetMatchingRankOrWild(this List<Card> input, Rank rank) =>
        input.Where(x => x.MatchesRankOrIsWild(rank)).ToList();

    public static List<Card> GetMatchingRankHand(
        this List<Card> input,
        Rank rank,
        int requiredCount
    )
    {
        if (!input.AnyWild())
            return input
                .Where(c => c.MatchesRank(rank))
                .OrderByDescending(c => c.Suit.Priority)
                .Take(requiredCount)
                .ToList();

        Queue<Card> wildCards = new();
        input.GetWild()
            .ForEach(wildCards.Enqueue);

        foreach(var r in Ranks.All.OrderByDescending(x => x.Value))
        {
            var cardsWithRank = input.GetMatchingRank(r);
            var neededCards = requiredCount - cardsWithRank.Count;

            if (neededCards > requiredCount)
                continue;

            List<Card> cardsOut = cardsWithRank
                .OrderByDescending(c => c.Suit.Priority)
                .Take(neededCards)
                .ToList();

            Queue<Card> targets = new();

            Cards
                .All
                .Where(c => c.MatchesRank(r))
                .Except(cardsWithRank)
                .OrderByDescending(c => c.Suit.Priority)
                .Take(neededCards)
                .ToList()
                .ForEach(targets.Enqueue);

            while(
                targets.Any()
                && wildCards.Any()
                && cardsOut.Count < requiredCount
                )
                cardsOut.Add(
                    wildCards.Dequeue() with { Impersonating = targets.Dequeue() }
                );

            if(cardsOut.Count > requiredCount)
                return cardsOut;
        }

        return input
            .Where(c => c.MatchesRankOrIsWild(rank))
            .OrderBy(c => c.IsWild)
            .ThenByDescending(c => c.Suit.Priority)
            .Take(requiredCount)
            .ToList();
    }

    public static List<Card> GetKickers(
        this List<Card> input,
        List<Card> handCards) =>
            input
                .Except(handCards)
                .OrderByDescending(c => c.IsWild)
                .ThenByDescending(c => c.Rank.Value)
                .ThenByDescending(c => c.Suit.Priority)
                .Take(GlobalConstants.HandSize - handCards.Count)
                .ToList();

    public static List<Card> GetDeadCards(
        this List<Card> input,
        List<Card> handCards,
        List<Card> kickers
        ) =>
        input
            .Except(handCards)
            .Except(kickers)
            .ToList();

    public static Rank GetMaxRank(this IEnumerable<Card> input)
    {
        var cards = input.ToList();
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
