namespace Poker.Domain.Extensions;

public static class CardExtensions
{
    public static bool MatchesRank(this Card input, Rank rank) =>
        input.Rank.Value == rank.Value;

    public static string ToDisplayString(this Card card, bool contributing)
    {
        StringBuilder s = new();

        var bold = contributing ? " bold" : string.Empty;

        // using gray100 instead of white because white is interpreted
        // by the terminal, and not always displayed as white.
        s.Append(card switch
        {
            { Suit.Name: "Spades" } => $"[black on grey100{bold}]",
            { Suit.Name: "Hearts" } => $"[red3 on grey100{bold}]",
            { Suit.Name: "Diamonds" } => $"[red1 on grey100{bold}]",
            { Suit.Name: "Clubs" } => $"[grey39 on grey100{bold}]",
            _ => "[green on white]"
        });

        var rankVal = card.Rank.IsStandard ? card.Rank.Value.ToString() : card.Rank.Name[..1];
        if (rankVal.Length == 1)
            s.Append(' ');
        s.Append(rankVal);

        s.Append(card.Suit.Name[..1]);

        s.Append("[/] ");

        // TODO: move this extension method to the terminal project, since
        // it is particular to Spectre Console
        return s.ToString();
    }

    public static CardInPlay DealToPlayer(
        this Card input,
        CardOrientations orientation
        ) =>
        new()
        {
            Card = input,
            CardLocation = CardLocations.PlayerHand,
            CardOrientation = orientation
        };

    public static CardInPlay DealFaceDownToPlayer(
        this Card input
    ) => input.DealToPlayer(CardOrientations.FaceDown);

    public static List<CardInPlay> DealToPlayer(
        this IEnumerable<Card> input,
        CardOrientations orientation
    ) =>
        input
            .Select(c => new CardInPlay
            {
                Card = c,
                CardLocation = CardLocations.PlayerHand,
                CardOrientation = orientation
            })
            .ToList();

}
