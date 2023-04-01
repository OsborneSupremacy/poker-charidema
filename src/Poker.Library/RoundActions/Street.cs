namespace Poker.Library.RoundActions;

public record Street : DealCards
{
    public Street()
    {
        Count = 1;
        Name = "The Street";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardDestinations.Community;
    }
}
