namespace Poker.Library;

public record Card
{
    public Rank Rank { get; init; }

    public Suit Suit { get; init; }
}
