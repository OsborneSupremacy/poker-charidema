namespace Poker.Domain.Messaging;

public record GameRequest
{
    /// <summary>
    /// Count of games played up to this point, not including the game that will be played with this request.
    /// </summary>
    public required int GameCount { get; init; }

    public required AntePreferences AntePreferences { get; init; }

    public required IReadOnlyList<Participant> Participants { get; init; }

    public required Variant Variant { get; init; }

    public required Deck Deck { get; init; }

    public required Participant Button { get; init; }
}
