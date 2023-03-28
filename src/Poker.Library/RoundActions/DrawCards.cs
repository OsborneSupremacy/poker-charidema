using Poker.Library.Cards;

namespace Poker.Library.RoundActions;

public record DrawCards : IRoundAction
{
    public uint Maximums { get; init; }

    public List<DrawCardsMaximums> Overrides { get; init; }

    public bool GameCanEndAfter => false;
}

public record DrawCardsMaximums
{
    public Rank Rank { get; set; }

    public uint Maximum { get; set; }
}