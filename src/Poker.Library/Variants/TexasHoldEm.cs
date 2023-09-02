using Poker.Library.Rounds;

namespace Poker.Library.Variants;

public record class TexasHoldEm : IVariant
{
    public string Name => "Texas Hold 'Em";

    public List<IRound> Rounds =>
        new()
        {
            new Ante(),
            new DealCards()
            {
                Count = 2,
                Name = "Deal",
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardLocations.PlayerHand
            },
            new BettingInterval(),
            new Flop(),
            new BettingInterval(),
            new Turn(),
            new BettingInterval(),
            new Street(),
            new BettingInterval()
        };
}
