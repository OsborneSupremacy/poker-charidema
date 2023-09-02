namespace Poker.Library.Cards;

public record Face : IStandardCard
{
    public Guid Id { get; } = Guid.NewGuid();

    public required FaceDirections FaceDirection { get; init; }

    public required List<Holding> Holdings { get; init; }

    public required IRank Rank { get; init; }

    public required ISuit Suit { get; init; }

    public bool IsWild { get; set; }

    public required CardOrientations CardOrientation { get; set; }
}

public enum FaceDirections
{
    Left,
    Right
}

public enum Holding
{
    None,
    Sword,
    Scepter,
    Flower,
    Fan,
    Lute,
    Shield
}
