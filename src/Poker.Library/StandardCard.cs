namespace Poker.Library;

public record StandardCard : Card, ICard
{
    public Rank Rank { get; init; }

    public Suit Suit { get; init; }
}
