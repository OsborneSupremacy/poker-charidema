namespace Poker.Domain;

public enum CardLocations
{
    Deck,
    PlayerHand,
    Community
}

public enum CardOrientations
{
    Faceup,
    Facedown
}

public enum FaceDirections
{
    NotApplicable,
    Left,
    Right
}
public enum CardTypes
{
    Spot,
    Face,
    Ace,
    Joker
}

public enum Holding
{
    Sword,
    Scepter,
    Flower,
    Fan,
    Lute,
    Shield
}

/// <summary>
/// Creating one card class with properties that don't apply to every
/// type of card violates interface segregation. However, Card is a fundamental
/// concept on this application, and is a property of several objects that
/// need to be changed frequently. Being able to use nondestructive mutuation
/// is very helpful in this use case, therefore I'm deliberately opting to not
/// segregate intefaces for the benefits of record types.
/// </summary>
public record Card
{
    public required Guid Id { get; init; }

    public required CardOrientations CardOrientation { get; init; }

    public required CardTypes CardType { get; init; }

    public required bool IsWild { get; init; }

    /// <summary>
    /// The card that the wild card is impersonating.
    /// </summary>
    public Card? Impersonating { get; set; }

    public required Rank? Rank { get; init; }

    public required Suit? Suit { get; init; }

    public required FaceDirections FaceDirection { get; init; }

    public required List<Holding> Holdings { get; init; }
}
