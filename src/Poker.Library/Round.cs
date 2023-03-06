namespace Poker.Library;

public record Round
{
    public double Pot { get; set; }

    public List<Bet> Bets { get; init; }

    public double Ante { get; init; }
}
