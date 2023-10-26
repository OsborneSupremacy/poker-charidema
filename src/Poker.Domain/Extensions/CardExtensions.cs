namespace Poker.Domain.Extensions;

public static class CardExtensions
{
    public static bool MatchesRank(this Card input, Rank rank) =>
        input.Rank.Value == rank.Value;

    public static bool MatchesSuit(this Card input, Suit suit) =>
        input.Suit.Priority == suit.Priority;

    public static string ToDisplayString(this Card card, bool contributing)
    {
        StringBuilder s = new();
        
        var rankVal = card.Rank.IsStandard ? card.Rank.Value.ToString() : card.Rank.Name[..1];
        if(rankVal.Length == 1)
            s.Append(' ');
        s.Append(rankVal);
        s.Append('-');
                
        s.Append(card.Suit.Name[..1]);
        
        if(contributing)
            s.Append('*');

        return s.ToString();
    }
}
