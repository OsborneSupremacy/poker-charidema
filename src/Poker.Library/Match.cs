namespace Poker.Library;

public record Match
{
    public required uint? FixedNumberOfGames { get; init; }

    public IVariant? FixedVariant { get; init; }

    public Deck? FixedDeck { get; init; }

    public required List<Player> Players { get; init; }

    public required List<Game> Games { get; init; }

    public required Player Button { get; init; }
}

public class  MatchValidator : AbstractValidator<Match>
{
    public MatchValidator()
    {

    }
}