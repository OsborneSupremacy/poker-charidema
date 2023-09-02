namespace Poker.Library.Interface;

public interface ICard
{
    Guid Id { get; }

    CardOrientations CardOrientation { get; set; }

    bool IsWild { get; }
}

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
