namespace Poker.Library.Rounds;

public record River : DealCards, IBoardAction
{
    public River()
    {
        Count = 1;
        Name = "The River";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardLocations.Community;
    }
}
