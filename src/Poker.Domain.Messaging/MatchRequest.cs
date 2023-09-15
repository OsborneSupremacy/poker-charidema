namespace Poker.Domain.Messaging;

public record class MatchRequest
{
    public required List<Participant> Players { get; init; }

    public required Participant InitialButton { get; init; }

    public required AntePreferences AntePreferences { get; init; }

    public required uint? FixedNumberOfGames { get; init; }

    public required Deck? FixedDeck { get; init; }

    public required Variant? FixedVariant { get; init; }

    public required uint StartingStack { get; init; }
}
