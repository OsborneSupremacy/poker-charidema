namespace Poker.Library.Rounds;

public record Turn : DealCards
{
    public Turn()
    {
        Count = 1;
        Name = "The Turn";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardDestinations.Community;
    }
}
