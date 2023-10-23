namespace Poker.Domain;

public enum CardLocations
{
    Empty,
    Deck,
    PlayerHand,
    Community
}

public enum CardOrientations
{
    Empty,
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
    Empty,
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
/// need to be changed frequently. Being able to use nondestructive mutation
/// is very helpful in this use case, therefore I'm deliberately opting to not
/// segregate interfaces for the benefits of record types.
/// </summary>
public record Card
{
    public required string Value { get; init; }

    public required CardTypes CardType { get; init; }

    public required bool IsWild { get; init; }

    public required Rank Rank { get; init; }

    public required Suit Suit { get; init; }

    public required FaceDirections FaceDirection { get; init; }

    public required List<Holding> Holdings { get; init; }
}
