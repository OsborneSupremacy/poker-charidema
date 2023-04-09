namespace Poker.Library.Rounds;

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
