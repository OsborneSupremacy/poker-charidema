namespace Poker.Library.Rounds;

public record DealCards : IRound
{
    public string? Name { get; set; }

    public uint Count { get; init; }

    public CardOrientations CardOrientation { get; init; }

    public CardDestinations CardDestination { get; init; }

    public bool GameCanEndAfter => false;
}
