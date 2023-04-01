namespace Poker.Library.RoundActions;

public record River : DealCards
{
    public River()
    {
        Count = 1;
        Name = "The River";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardDestinations.Community;
    }
}
