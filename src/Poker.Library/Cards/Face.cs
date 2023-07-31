namespace Poker.Library.Cards;

public record Face : IStandardCard, ICard
{
    public Guid Id { get; } = Guid.NewGuid();

    public FaceDirections FaceDirection { get; init; }

    public List<HoldingObject>? HoldingObjects { get; init; }

    public required IRank Rank { get; init; }

    public required ISuit Suit { get; init; }

    public bool IsWild { get; set; }

    public CardOrientations CardOrientation { get; set; }
}

public enum FaceDirections
{
    Left,
    Right
}

public enum HoldingObject
{
    None,
    Sword,
    Scepter,
    Flower,
    Shield
}
