namespace Poker.Library.RoundActions;

public record DealCards : RoundAction
{
    public string Name { get; set; }

    public uint Count { get; init; }

    public CardOrientations CardOrientation { get; init; }

    public CardDestinations CardDestination { get; init; }
}
