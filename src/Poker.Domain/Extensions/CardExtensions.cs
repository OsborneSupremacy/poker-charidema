namespace Poker.Domain.Extensions;

internal static class CardExtensions
{
    public static bool MatchesRank(this Card input, Rank rank) =>
        input.Rank.Value == rank.Value;

    public static bool MatchesRankOrIsWild(this Card input, Rank rank) =>
        input.MatchesRank(rank)
        || input.IsWild;

    public static bool MatchesSuit(this Card input, Suit suit) =>
        input.Suit.Priority == suit.Priority;

    public static bool MatchesSuitOrIsWild(this Card input, Suit suit) =>
        input.MatchesSuit(suit)
        || input.IsWild;
}
