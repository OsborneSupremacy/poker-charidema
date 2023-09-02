namespace Poker.Library.Rounds;

public record DealCards : IRound
{
    public required string Name { get; set; }

    public uint Count { get; init; }

    public CardOrientations CardOrientation { get; init; }

    public CardLocations CardDestination { get; init; }

    public bool GameCanEndAfter => false;
}
