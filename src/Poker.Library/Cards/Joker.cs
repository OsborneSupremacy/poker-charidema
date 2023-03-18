namespace Poker.Library.Cards;

public record Joker : Card, ICard
{
    public new static bool IsWild { get => true; }
}
