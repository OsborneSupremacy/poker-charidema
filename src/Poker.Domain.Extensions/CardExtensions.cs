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
            _ => "?"
        };

    public static string GetSymbol(this Card input) =>
        input.Suit?.Name[..1].ToString().ToLowerInvariant() ?? string.Empty;

    public static bool MatchesRank(this Card input, uint rankValue) =>
        input.Rank is not null
            && input.Rank.Value == rankValue;

    public static bool IsStandardWild(this Card input) =>
        input.IsWild && input.CardType != CardTypes.Joker;

    public static bool MatchesRankOrIsWild(this Card input, uint rankValue) =>
        input.MatchesRank(rankValue)
        || input.IsWild;

    public static bool MatchesSuit(this Card input, uint suitPriority) =>
        input.Suit is not null
        && input.Suit.Priority == suitPriority;

    public static bool MatchesSuitOrIsWild(this Card input, uint suitPriority) =>
        input.MatchesSuit(suitPriority)
        || input.IsWild;

    public static bool HasCountOfMatchingRank(this IList<Card> input, uint rankValue, int count) =>
        input.Count(x => x.MatchesRank(rankValue)) >= count;

    public static bool HasCountOfMatchingRankOrWild(this IList<Card> input, uint rankValue, int count) =>
        input.Count(x => x.MatchesRankOrIsWild(rankValue)) >= count;

    public static List<Card> GetMatchingRank(this IList<Card> input, uint rankValue) =>
        input.Where(x => x.MatchesRank(rankValue)).ToList();

    public static List<Card> GetMatchingRankOrWild(this IList<Card> input, uint rankValue) =>
        input.Where(x => x.MatchesRankOrIsWild(rankValue)).ToList();

    public static List<Card> GetKickers(this IList<Card> input, List<Card> handCards, int handLimit)
    {
        List<Card> nonHandCards = input
            .Except(handCards).ToList();

        List<Card> jokers = nonHandCards
            .Where(j => j.CardType == CardTypes.Joker).ToList();

        List<Card> additionalCards = nonHandCards
            .Where(c => c.Rank is not null)
            .OrderByDescending(c => c.Rank!.Value)
            .ThenByDescending(c => c.Suit!.Priority)
            .Take(handLimit - jokers.Count)
            .ToList();

        return jokers
            .Union(additionalCards)
            .ToList();
    }

    public static List<Card> GetDeadCards(
        this IList<Card> input,
        List<Card> handCards,
        List<Card> kickers
        ) =>
        input
            .Except(handCards)
            .Except(kickers)
            .ToList();
}
