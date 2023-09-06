using System.Formats.Asn1;

namespace Poker.Library;

public record Match
{
    public required uint? FixedNumberOfGames { get; init; }

    public IVariant? FixedVariant { get; init; }

    public IDeck? FixedDeck { get; init; }

    public required List<IPlayer> Players { get; init; }

    public required List<Game> Games { get; init; }

    public required IPlayer Button { get; init; }

    public required uint? FixedAnte {  get; init; }

    public required uint StartingStack { get; init; }
}

public class MatchValidator : AbstractValidator<Match>
{
    public MatchValidator()
    {

    }
}
