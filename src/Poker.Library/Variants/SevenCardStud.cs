using Poker.Library.Rounds;

namespace Poker.Library.Variants;

public record SevenCardStud : IVariant
{
    public string Name => "Seven Card Stud";

    public List<IRound> Rounds =>
        new()
        {
            new Ante(),
            new DealCards()
            {
                Name = "Deal",
                Count = 2,
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardDestinations.PlayerHand
            },
            new DealCards()
            {
                Name = "Deal",
                Count = 1,
                CardOrientation = CardOrientations.Faceup,
                CardDestination = CardDestinations.PlayerHand
            },
            new BettingInterval(),
            new DealCards()
            {
                Name = "Deal",
                Count = 3,
                CardOrientation = CardOrientations.Faceup,
                CardDestination = CardDestinations.PlayerHand
            },
            new DealCards()
            {
                Name = "Deal",
                Count = 1,
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardDestinations.PlayerHand
            },
            new BettingInterval()
        };
}
