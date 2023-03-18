using Poker.Library.Cards;

namespace Poker.Library;

public record Game
{
    public Variant Variant { get; init; }

    public double Ante { get; init; }

    public double Pot { get; init; }

    public Deck Deck { get; init; }

    public List<Card> CommunityCards { get; init; }

    public List<Card> Discards { get; init; }

    public List<Player> Players { get; init; }

    public List<Round> Rounds { get; init; }

    public enum Phases
    {
        NotStarted,
        Shuffle,
        PromptForAnte,
        InitialDeal,
        Rounds,
        DetermineWinner,
        Completed
    }

    public Phases Phase { get; init; }
}
