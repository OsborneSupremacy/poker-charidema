namespace Poker.Domain.Classic;

public static class Ranks
{
    public static Rank Empty { get; } = new()
    {
        Name = "Empty",
        Value = 0,
        IsStandard = false
    };
    
    public static Rank Two { get; } = new()
    {
        Name = "Two",
        Value = 2,
        IsStandard = true
    };
    
    public static Rank Three { get; } = new()
    {
        Name = "Three",
        Value = 3,
        IsStandard = true
    };
    
    public static Rank Four { get; } = new()
    {
        Name = "Four",
        Value = 4,
        IsStandard = true
    };
    
    public static Rank Five { get; } = new()
    {
        Name = "Five",
        Value = 5,
        IsStandard = true
    };
    
    public static Rank Six { get; } = new()
    {
        Name = "Six",
        Value = 6,
        IsStandard = true
    };
    
    public static Rank Seven { get; } = new()
    {
        Name = "Seven",
        Value = 7,
        IsStandard = true
    };
    
    public static Rank Eight { get; } = new()
    {
        Name = "Eight",
        Value = 8,
        IsStandard = true
    };
    
    public static Rank Nine { get; } = new()
    {
        Name = "Nine",
        Value = 9,
        IsStandard = true
    };
    
    public static Rank Ten { get; } = new()
    {
        Name = "Ten",
        Value = 10,
        IsStandard = true
    };
    
    public static Rank Jack { get; } = new()
    {
        Name = "Jack",
        Value = 11,
        IsStandard = false
    };
    
    public static Rank Queen { get; } = new()
    {
        Name = "Queen",
        Value = 12,
        IsStandard = false
    };
    
    public static Rank King { get; } = new()
    {
        Name = "King",
        Value = 13,
        IsStandard = false
    };
    
    public static Rank Ace { get; } = new()
    {
        Name = "Ace",
        Value = 14,
        IsStandard = false
    };

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
