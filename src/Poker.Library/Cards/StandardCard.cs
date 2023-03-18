namespace Poker.Library.Cards;

public abstract record StandardCard : Card, ICard
{
    public Rank Rank { get; init; }

    public Suit Suit { get; init; }
}
