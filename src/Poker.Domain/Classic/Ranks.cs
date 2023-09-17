namespace Poker.Domain.Classic;

public record Ranks
{
    public static Rank Empty { get; } = new Rank(nameof(Empty), 0);

    public static Rank Two { get; } = new Rank(nameof(Two), 2);

    public static Rank Three { get; } = new Rank(nameof(Three), 3);

    public static Rank Four { get; } = new Rank(nameof(Four), 4);

    public static Rank Five { get; } = new Rank(nameof(Five), 5);

    public static Rank Six { get; } = new Rank(nameof(Six), 6);

    public static Rank Seven { get; } = new Rank(nameof(Seven), 7);

    public static Rank Eight { get; } = new Rank(nameof(Eight), 8);

    public static Rank Nine { get; } = new Rank(nameof(Nine), 9);

    public static Rank Ten { get; } = new Rank(nameof(Ten), 10);

    public static Rank Jack { get; } = new Rank(nameof(Jack), 11);

    public static Rank Queen { get; } = new Rank(nameof(Queen), 12);

    public static Rank King { get; } = new Rank(nameof(King), 13);

    public static Rank Ace { get; } = new Rank(nameof(Ace), 14);

    public static List<Rank> All { get; } = new() {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    };
}
