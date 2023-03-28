namespace Poker.Library.Cards;

public record Face : Standard, ICard
{
    public FaceDirections FaceDirection { get; init; }

    public List<HoldingObject>? HoldingObjects { get; init; }

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