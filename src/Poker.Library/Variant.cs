namespace Poker.Library;

public record Variant
{
    public string Name { get; init; }

    public List<Round> Rounds { get; init; }

    // settings for wild cards

}
