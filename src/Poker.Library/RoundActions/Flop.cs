using Poker.Library.Cards;

namespace Poker.Library.RoundActions;

public record Flop : DealCards
{
    public Flop()
    {
        Count = 3;
        Name = "The Flop";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardDestinations.Community;
    }
}
