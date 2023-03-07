namespace Poker.Library;

public record DealCardsAction : RoundAction
{
    public string Name { get; set; }

    public uint Count { get; init; }

    public CardOrientations CardOrientation { get; init; }

    public CardDestinations CardDestination { get; init; }
}
