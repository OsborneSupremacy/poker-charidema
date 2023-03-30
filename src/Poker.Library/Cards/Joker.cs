namespace Poker.Library.Cards;

public record Joker : ICard
{
    public CardOrientations CardOrientation { get; set; }

    public Guid Id => throw new NotImplementedException();

    bool ICard.IsWild => true;
}
