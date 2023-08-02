namespace Poker.Library.Cards;

public record Spot : IStandardCard, ICard
{
    public Guid Id { get; } = Guid.NewGuid();

    public required IRank Rank { get; init; }

    public required ISuit Suit { get; init; }

    public bool IsWild { get; set; }

    public required CardOrientations CardOrientation { get; set; }
}
