namespace Poker.Domain;

public record Hand
{
    public required string Name { get; init; }

    public required uint Value { get; init; }

    /// <summary>
    /// The count of required matches in the first group. e.g. a Pair is 2. A full house is 3.
    /// </summary>
    public required uint PrimaryMatchesCount { get; init; }

    /// <summary>
    /// The count of required matches in the first group. e.g. a Pair is 0. A full house is 2. Two Pair is 2.
    /// Only two of these properties is defined (as opposed to a collection) because classic
    /// Poker hands (the only type I'm currently supporting) allow for two match groups at the most.
    /// </summary>
    public required uint SecondaryMatchesCount { get; init; }

    /// <summary>
    /// Whether the hand requires the cards to be in a sequence
    /// </summary>
    public required bool Sequence { get; init; }

    /// <summary>
    /// If the hand requires a sequence, the minimum rank that can count in the sequence.
    /// e.g. Royal Flush has a mininum rank of 10
    /// </summary>
    public required Rank SequenceMinRank { get; init; }

    /// <summary>
    /// Whether the hand requires cards of the same suite
    /// </summary>
    public required bool Uniform { get; init; }
}
