namespace Poker.Library;

public record Match
{
    public required uint? FixedNumberOfGames { get; init; }

    public IVariant? FixedVariant { get; init; }

    public IDeck? FixedDeck { get; init; }

    public required List<Participant> Players { get; init; }

    public required List<Game> Games { get; init; }

    public required Participant Button { get; init; }

    public required IAntePreferences AntePreferences { get; init; }

    public required uint StartingStack { get; init; }
}

public class MatchValidator : AbstractValidator<Match>
{
    public MatchValidator()
    {

    }
}
