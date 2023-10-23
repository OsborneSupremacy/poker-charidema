namespace Poker.Domain.Classic;

public static class Ranks
{
    public static Rank Empty { get; } = new(nameof(Empty), 0);

    public static Rank Two { get; } = new(nameof(Two), 2);

    public static Rank Three { get; } = new(nameof(Three), 3);

    public static Rank Four { get; } = new(nameof(Four), 4);

    public static Rank Five { get; } = new(nameof(Five), 5);

    public static Rank Six { get; } = new(nameof(Six), 6);

    public static Rank Seven { get; } = new(nameof(Seven), 7);

    public static Rank Eight { get; } = new(nameof(Eight), 8);

    public static Rank Nine { get; } = new(nameof(Nine), 9);

    public static Rank Ten { get; } = new(nameof(Ten), 10);

    public static Rank Jack { get; } = new(nameof(Jack), 11);

    public static Rank Queen { get; } = new(nameof(Queen), 12);

    public static Rank King { get; } = new(nameof(King), 13);

    public static Rank Ace { get; } = new(nameof(Ace), 14);

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
