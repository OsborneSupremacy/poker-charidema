namespace Poker.Library.RoundActions;

public record DrawCards : RoundAction
{
    public uint Maximums { get; init; }

    public List<DrawCardsMaximums> Overrides { get; init; }

    public override bool GameCanEndAfter => false;
}

public record DrawCardsMaximums
{
    public Rank Rank { get; set; }

    public uint Maximum { get; set; }
}