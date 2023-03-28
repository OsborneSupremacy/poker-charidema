using Poker.Library.Cards;

namespace Poker.Library.Classic;

public record Ranks
{
    public Rank Two { get; init; }

    public Rank Three { get; init; }

    public Rank Four { get; init; }

    public Rank Five { get; init; }

    public Rank Six { get; init; }

    public Rank Seven { get; init; }

    public Rank Eight { get; init; }

    public Rank Nine { get; init; }

    public Rank Ten { get; init; }

    public Rank Jack { get; init; }

    public Rank Queen { get; init; }

    public Rank King { get; init; }

    public Rank Ace { get; init; }

    public Ranks()
    {
        Two = new Rank(nameof(Two), 2);
        Three = new Rank(nameof(Three), 3);
        Four = new Rank(nameof(Four), 4);
        Five = new Rank(nameof(Five), 5);
        Six = new Rank(nameof(Six), 6);
        Seven = new Rank(nameof(Seven), 7);
        Eight = new Rank(nameof(Eight), 8);
        Nine = new Rank(nameof(Nine), 9);
        Ten = new Rank(nameof(Ten), 10);
        Jack = new Rank(nameof(Jack), 11);
        Queen = new Rank(nameof(Queen), 12);
        King = new Rank(nameof(King), 13);
        Ace = new Rank(nameof(Ace), 14);
    }
}
