namespace Poker.Library.Cards;

public record Joker : ICard
{
    public CardOrientations CardOrientation { get; set; }

    public Guid Id => throw new NotImplementedException();

    bool ICard.IsWild => true;

    /// <summary>
    /// The card that the Joker is acting as
    /// </summary>
    public ICard? ImpersonatingCard { get; init; }
}
