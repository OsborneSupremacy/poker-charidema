namespace Poker.Library;

public record Hand
{
    public double Pot { get; set; }

    public Person Dealer { get; init; }

    public List<Bet> Bets { get; init; }

    public double Ante { get; init; }
}
