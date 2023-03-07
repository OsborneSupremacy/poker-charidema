namespace Poker.Library;

public abstract record Variant
{
    public abstract string Name { get; }

    public abstract List<RoundAction> RoundActions { get; }

    // settings for wild cards

}
