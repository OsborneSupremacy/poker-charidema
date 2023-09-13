using Poker.Library.Phases;
using Poker.Library.Rounds;

namespace Poker.Library.Variants;

public record SevenCardStud : IVariant
{
    public string Name => "Seven Card Stud";

    public List<IPhase> Phases =>
        new()
        {
            new Ante(),
            new DealCards()
            {
                Name = "Deal",
                Count = 2,
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardLocations.PlayerHand
            },
            new DealCards()
            {
                Name = "Deal",
                Count = 1,
                CardOrientation = CardOrientations.Faceup,
                CardDestination = CardLocations.PlayerHand
            },
            new BettingInterval(),
            new DealCards()
            {
                Name = "Deal",
                Count = 3,
                CardOrientation = CardOrientations.Faceup,
                CardDestination = CardLocations.PlayerHand
            },
            new DealCards()
            {
                Name = "Deal",
                Count = 1,
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardLocations.PlayerHand
            },
            new BettingInterval()
        };
}
