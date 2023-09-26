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
}
