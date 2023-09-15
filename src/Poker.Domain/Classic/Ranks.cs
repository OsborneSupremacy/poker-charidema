namespace Poker.Domain.Classic;

public record Ranks
{
    public Rank Two { get; }

    public Rank Three { get; }

    public Rank Four { get; }

    public Rank Five { get; }

    public Rank Six { get; }

    public Rank Seven { get; }

    public Rank Eight { get; }

    public Rank Nine { get; }

    public Rank Ten { get; }

    public Rank Jack { get; }

    public Rank Queen { get; }

    public Rank King { get; }

    public Rank Ace { get; }

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
