namespace Poker.Library.Cards;

public record Spot : IStandardCard, ICard
{
    public Guid Id { get; } = Guid.NewGuid();

    public IRank Rank { get; init; }

    public ISuit Suit { get; init; }

    public bool IsWild { get; set; }

    public CardOrientations CardOrientation { get; set; }

}
