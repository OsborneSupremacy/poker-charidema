namespace Poker.Library.Interface;

public interface IDeck
{
    List<ICard> Cards { get; init; }

    uint NumberOfJokers { get; init; }

    /// <summary>
    /// Distinct list of card rank values, in descending order.
    /// </summary>
    List<uint> CardRankValues { get; init; }

    /// <summary>
    /// Distinct list of card rank values, in descending order.
    /// </summary>
    List<uint> CardSuitPriorities { get; init; }
}
